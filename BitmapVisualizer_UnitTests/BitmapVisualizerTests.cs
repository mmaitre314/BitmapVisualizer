using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.Text.Editor;
using MMaitre.BitmapVisualizer;
using EnvDTE;
using Microsoft.VisualStudio.Text;

namespace BitmapVisualizer_UnitTests
{
    [TestClass]
    public class BitmapVisualizerTests
    {
        [TestMethod]
        public void BitmapVisualizer_CreateInstance()
        {
            var view = new MockWpfTextView();
            var debugger = new MockDebugger();

            var visualizer = new BitmapVisualizer(debugger, view);
        }

        [TestMethod]
        public void BitmapVisualizer_NonDebugBreakMode()
        {
            var view = new MockWpfTextView();
            var debugger = new MockDebugger();

            var visualizer = new BitmapVisualizer(debugger, view);

            view.InvokeMouseHover(new MouseHoverEventArgs(view, 0, new MockMappingPoint("bitmap")));
        }

        [TestMethod]
        public void BitmapVisualizer_DisplayBitmap()
        {
            var view = new MockWpfTextView();
            var debugger = new MockDebugger();

            debugger.SetCurrentMode(dbgDebugMode.dbgBreakMode);

            var visualizer = new BitmapVisualizer(debugger, view);

            view.InvokeMouseHover(new MouseHoverEventArgs(view, 0, new MockMappingPoint("bitmap")));

            Assert.IsTrue(view.AdornmentLayer.WasAddAdornmentCalled);
        }
    }
}
