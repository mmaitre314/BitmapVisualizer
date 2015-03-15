using EnvDTE;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MMaitre.BitmapVisualizer
{
    class DebuggerVariable
    {
        internal readonly SnapshotPoint Point;
        internal readonly SnapshotSpan Span;
        internal readonly String Name;
        internal readonly String Type;
        internal readonly String Value;

        private static Regex m_variableExtractor = new Regex("[a-zA-Z0-9_.]+");
        private EnvDTE.Debugger m_debugger;

        internal static DebuggerVariable FindUnderMousePointer(EnvDTE.Debugger debugger, MouseHoverEventArgs e)
        {
            Debug.Assert(debugger != null);

            var point = e.TextPosition.GetPoint(e.TextPosition.AnchorBuffer, PositionAffinity.Predecessor);
            if (!point.HasValue)
            {
                return null;
            }

            SnapshotSpan span;
            var name = GetVariableNameAndSpan(point.Value, out span);
            if (name == null)
            {
                return null;
            }

            var expression = debugger.GetExpression(name);
            if (!expression.IsValidValue)
            {
                return null;
            }

            return new DebuggerVariable(debugger, point.Value, span, name, expression);
        }

        private static string GetVariableNameAndSpan(SnapshotPoint point, out SnapshotSpan span)
        {
            var line = point.GetContainingLine();
            var hoveredIndex = point.Position - line.Start.Position;

            var c = point.GetChar();
            if (!Char.IsDigit(c) && !Char.IsLetter(c) && (c != '_'))
            {
                span = new SnapshotSpan();
                return null;
            }

            // Find the name of the variable under the mouse pointer (ex: 'gesture.Pose.Name' when the mouse is hovering over the 'o' of pose)
            var match = m_variableExtractor.Matches(line.GetText()).OfType<Match>().SingleOrDefault(x => x.Index <= hoveredIndex && (x.Index + x.Length) >= hoveredIndex);
            if ((match == null) || (match.Value.Length == 0))
            {
                span = new SnapshotSpan();
                return null;
            }
            var name = match.Value;

            // Find the first '.' after the hoveredIndex and cut it off
            int relativeIndex = hoveredIndex - match.Index;
            var lastIndex = name.IndexOf('.', relativeIndex);
            if (lastIndex >= 0)
            {
                name = name.Substring(0, lastIndex);
            }
            else
            {
                lastIndex = name.Length;
            }

            var matchStartIndex = name.LastIndexOf('.', relativeIndex) + 1;
            span = new SnapshotSpan(line.Start.Add(match.Index + matchStartIndex), lastIndex - matchStartIndex);

            return name;
        }

        private DebuggerVariable(EnvDTE.Debugger debugger, SnapshotPoint point, SnapshotSpan span, string name, Expression expression)
        {
            this.m_debugger = debugger;
            this.Point = point;
            this.Span = span;
            this.Name = name;
            this.Type = expression.Type;
            this.Value = expression.Value;
        }

        internal string GetMemberString(string name)
        {
            var expression = m_debugger.GetExpression(this.Name + "." + name); // ex: "bitmap.ColorMode", "bitmap.Dimensions.Width", "bitmap.Buffers[0].Pitch"

            if (!expression.IsValidValue)
            {
                return null;
            }
            else
            {
                if (expression.Type == "string")
                {
                    return expression.Value.Substring(1, expression.Value.Length - 2); // Remove '"' string quotes at the beginning and the end
                }
                else
                {
                    return expression.Value;
                }
            }
        }

        internal double? GetMemberDouble(string name)
        {
            var valueAsString = GetMemberString(name);

            double value;
            return Double.TryParse(valueAsString, out value) ? new double?(value) : null;
        }

        internal uint? GetMemberUInt32(string name)
        {
            var valueAsString = GetMemberString(name);

            uint value;
            return UInt32.TryParse(valueAsString, out value) ? new uint?(value) : null;
        }

        internal byte[] GetMemberIBuffer(string name)
        {
            // Serialize the IBuffer to string and copy from debuggee to debugger
            var expressionText = "Convert.ToBase64String(System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeBufferExtensions.ToArray(" + this.Name + "." + name + "));";
            var expression = m_debugger.GetExpression(expressionText);
            if (!expression.IsValidValue)
            {
                return null;
            }

            // Deserialize buffer
            var bufferInBase64 = expression.Value.Substring(1, expression.Value.Length - 2); // Remove '"' string quotes at the beginning and the end
            byte[] buffer;
            try
            {
                buffer = Convert.FromBase64String(bufferInBase64);
            }
            catch (FormatException)
            {
                return null;
            }
            return buffer;
        }
    }
}
