using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MMaitre.BitmapVisualizer
{
    public sealed class BitmapVisualizer
    {
        public const string AdornmentLayerName = "MMaitre.BitmapVisualizer";

        private EnvDTE.Debugger m_debugger;
        private IWpfTextView m_view;
        private IAdornmentLayer m_layer;
        private UserControl m_control;
        private volatile bool m_mouseOverControl;

        private const int AdornmentLeftOffset = 20;

        public BitmapVisualizer(EnvDTE.Debugger debugger, IWpfTextView view)
        {
            Logger.EnterMethod(this);

            m_debugger = debugger;
            Debug.Assert(m_debugger != null);

            m_view = view;
            m_layer = m_view.GetAdornmentLayer(AdornmentLayerName);
            m_view.MouseHover += OnMouseHover;

            Logger.ExitMethod(this);
        }

        private void OnMouseHover(object sender, MouseHoverEventArgs e)
        {
            Logger.EnterMethod(this);

            if (m_mouseOverControl)
            {
                Logger.ExitMethodWithMessage(this, "Mouse over control");
                return;
            }

            if (m_debugger.CurrentMode != dbgDebugMode.dbgBreakMode)
            {
                Logger.ExitMethodWithMessage(this, "Not in debug-break mode");
                return;
            }

            RemoveAdornment();

            var variable = DebuggerVariable.FindUnderMousePointer(m_debugger, e);
            if (variable == null)
            {
                Logger.ExitMethodWithMessage(this, "No variable");
                return;
            }

            var bitmapSource = GetBitmapSource(variable);
            if (bitmapSource == null)
            {
                Logger.ExitMethodWithMessage(this, "No BitmapSource");
                return;
            }

            CreateControl(bitmapSource);
            AddAdornment(variable);

            Logger.ExitMethod(this);
        }

        private BitmapSource GetBitmapSource(DebuggerVariable variable)
        {
            Logger.EnterMethod(this);

            if (variable.Type != "Lumia.Imaging.Bitmap")
            {
                Logger.ExitMethodWithMessage(this, String.Format("Invalid variable type: {0}", variable.Type));
                return null;
            }

            if (variable.Value == "null")
            {
                Logger.ExitMethodWithMessage(this, "Variable null");
                return null;
            }

            var width = variable.GetMemberDouble("Dimensions.Width");
            if (!width.HasValue || Double.IsInfinity(width.Value) || Double.IsNaN(width.Value) || (width.Value <= 0))
            {
                Logger.ExitMethodWithMessage(this, String.Format("Invalid width: HasValue {0}, Value {1}", width.HasValue, width.GetValueOrDefault()));
                return null;
            }

            var height = variable.GetMemberDouble("Dimensions.Height");
            if (!height.HasValue || Double.IsInfinity(height.Value) || Double.IsNaN(height.Value) || (height.Value <= 0))
            {
                Logger.ExitMethodWithMessage(this, String.Format("Invalid height: HasValue {0}, Value {1}", height.HasValue, height.GetValueOrDefault()));
                return null;
            }

            var pitch = variable.GetMemberUInt32("Buffers[0].Pitch");
            if (!pitch.HasValue || (pitch.Value <= 0))
            {
                Logger.ExitMethodWithMessage(this, String.Format("Invalid pitch: HasValue {0}, Value {1}", pitch.HasValue, pitch.GetValueOrDefault()));
                return null;
            }

            var colorMode = variable.GetMemberString("ColorMode");
            if ((colorMode == null) || (colorMode != "Bgra8888") && (colorMode != "Pbgra8888"))
            {
                Logger.ExitMethodWithMessage(this, String.Format("Invalid color mode: {0}", colorMode));
                return null;
            }

            var buffer = variable.GetMemberIBuffer("Buffers[0].Buffer");
            if ((buffer == null) || (buffer.Length < pitch.Value * (uint)height.Value))
            {
                Logger.ExitMethodWithMessage(this, String.Format("Invalid buffer length: {0}", buffer != null ? buffer.Length : 0));
                return null;
            }

            Logger.Message(this, String.Format("Creating WriteableBitmap {0}x{1}, pitch {2}", (int)width, (int)height, (int)pitch));

            var bitmap = new WriteableBitmap((int)width, (int)height, 96.0, 96.0, PixelFormats.Bgr32, BitmapPalettes.WebPalette);
            bitmap.WritePixels(new Int32Rect(0, 0, bitmap.PixelWidth, bitmap.PixelHeight), buffer, (int)pitch, 0);

            Logger.ExitMethod(this);
            return bitmap;
        }

        private void CreateControl(BitmapSource bitmapImage)
        {
            Logger.EnterMethod(this);

            var control = new BitmapVisualizerControl();
            control.Preview.Source = bitmapImage;
            control.MouseEnter += (sender, e) => 
            { 
                m_mouseOverControl = true; 
            };
            control.MouseLeave += (sender, e) =>
            {
                m_mouseOverControl = false;
                RemoveAdornment();
            };

            m_control = control;

            Logger.ExitMethod(this);
        }

        private void AddAdornment(DebuggerVariable variable)
        {
            Logger.EnterMethod(this);

            var markerGeometry = m_view.TextViewLines.GetMarkerGeometry(variable.Span);
            var line = m_view.GetTextViewLineContainingBufferPosition(variable.Span.Start);

            m_layer.AddAdornment(AdornmentPositioningBehavior.TextRelative, variable.Span, null, m_control, null);
            m_control.UpdateLayout();

            Canvas.SetLeft(m_control, Math.Max(0, markerGeometry.Bounds.Left - AdornmentLeftOffset));
            Canvas.SetTop(m_control, line.Top - m_control.ActualHeight);

            Logger.ExitMethod(this);
        }

        private void RemoveAdornment()
        {
            Logger.EnterMethod(this);

            if (m_control != null)
            {
                m_layer.RemoveAdornment(m_control);
                m_control = null;
            }

            Logger.ExitMethod(this);
        }
    }
}
