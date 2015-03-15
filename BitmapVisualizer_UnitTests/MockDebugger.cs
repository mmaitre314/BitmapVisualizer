using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvDTE;

namespace BitmapVisualizer_UnitTests
{
    class MockDebugger : Debugger
    {
        private dbgDebugMode m_debugMode = dbgDebugMode.dbgDesignMode;

        public Breakpoints AllBreakpointsLastHit
        {
            get { throw new NotImplementedException(); }
        }

        public void Break(bool WaitForBreakMode = true)
        {
            throw new NotImplementedException();
        }

        public Breakpoint BreakpointLastHit
        {
            get { throw new NotImplementedException(); }
        }

        public Breakpoints Breakpoints
        {
            get { throw new NotImplementedException(); }
        }

        public dbgDebugMode CurrentMode
        {
            get { return m_debugMode; }
        }

        public Process CurrentProcess
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Program CurrentProgram
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public StackFrame CurrentStackFrame
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Thread CurrentThread
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public DTE DTE
        {
            get { throw new NotImplementedException(); }
        }

        public Processes DebuggedProcesses
        {
            get { throw new NotImplementedException(); }
        }

        public void DetachAll()
        {
            throw new NotImplementedException();
        }

        public void ExecuteStatement(string Statement, int Timeout = -1, bool TreatAsExpression = false)
        {
            throw new NotImplementedException();
        }

        public Expression GetExpression(string ExpressionText, bool UseAutoExpandRules = false, int Timeout = -1)
        {
            Console.WriteLine("MockDebugger.GetExpression(\"{0}\", {1}, {2})", ExpressionText, UseAutoExpandRules, Timeout);

            if (ExpressionText == "bitmap")
            {
                return new MockExpression(true, "Lumia.Imaging.Bitmap", "Bitmap");
            }
            else if (ExpressionText == "bitmap.Dimensions.Width")
            {
                return new MockExpression(true, "double", "640.0");
            }
            else if (ExpressionText == "bitmap.Dimensions.Height")
            {
                return new MockExpression(true, "double", "480.0");
            }
            else if (ExpressionText == "bitmap.Buffers[0].Pitch")
            {
                return new MockExpression(true, "uint", "2560");
            }
            else if (ExpressionText == "bitmap.ColorMode")
            {
                return new MockExpression(true, "Lumia.Imaging.ColorMode", "Bgra8888");
            }
            else if (ExpressionText == "Convert.ToBase64String(System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeBufferExtensions.ToArray(bitmap.Buffers[0].Buffer));")
            {
                return new MockExpression(true, "string", "\"" + Convert.ToBase64String(new byte[2560 * 480]) + "\"");
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public void Go(bool WaitForBreakOrEnd = true)
        {
            throw new NotImplementedException();
        }

        public bool HexDisplayMode
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool HexInputMode
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Languages Languages
        {
            get { throw new NotImplementedException(); }
        }

        public dbgEventReason LastBreakReason
        {
            get { throw new NotImplementedException(); }
        }

        public Processes LocalProcesses
        {
            get { throw new NotImplementedException(); }
        }

        public DTE Parent
        {
            get { throw new NotImplementedException(); }
        }

        public void RunToCursor(bool WaitForBreakOrEnd = true)
        {
            throw new NotImplementedException();
        }

        public void SetNextStatement()
        {
            throw new NotImplementedException();
        }

        public void StepInto(bool WaitForBreakOrEnd = true)
        {
            throw new NotImplementedException();
        }

        public void StepOut(bool WaitForBreakOrEnd = true)
        {
            throw new NotImplementedException();
        }

        public void StepOver(bool WaitForBreakOrEnd = true)
        {
            throw new NotImplementedException();
        }

        public void Stop(bool WaitForDesignMode = true)
        {
            throw new NotImplementedException();
        }

        public void TerminateAll()
        {
            throw new NotImplementedException();
        }

        internal void SetCurrentMode(dbgDebugMode debugMode)
        {
            m_debugMode = debugMode;
        }
    }
}
