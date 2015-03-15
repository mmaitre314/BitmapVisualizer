using Microsoft.VisualStudio.Text.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmapVisualizer_UnitTests
{
    class MockWpfTextView : IWpfTextView
    {
        internal MockAdornmentLayer AdornmentLayer = new MockAdornmentLayer();

        public System.Windows.Media.Brush Background
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

        public event EventHandler<BackgroundBrushChangedEventArgs> BackgroundBrushChanged;

        public Microsoft.VisualStudio.Text.Formatting.IFormattedLineSource FormattedLineSource
        {
            get { throw new NotImplementedException(); }
        }

        public IAdornmentLayer GetAdornmentLayer(string name)
        {
            if (name != "MMaitre.BitmapVisualizer")
            {
                throw new NotImplementedException();
            }
            else
            {
                return this.AdornmentLayer;
            }
        }

        public ISpaceReservationManager GetSpaceReservationManager(string name)
        {
            throw new NotImplementedException();
        }

        public Microsoft.VisualStudio.Text.Formatting.IWpfTextViewLine GetTextViewLineContainingBufferPosition(Microsoft.VisualStudio.Text.SnapshotPoint bufferPosition)
        {
            return new MockWpfTextViewLine();
        }

        public Microsoft.VisualStudio.Text.Formatting.ILineTransformSource LineTransformSource
        {
            get { throw new NotImplementedException(); }
        }

        public IWpfTextViewLineCollection TextViewLines
        {
            get { return new MockWpfTextViewLineCollection(); }
        }

        public System.Windows.FrameworkElement VisualElement
        {
            get { throw new NotImplementedException(); }
        }

        public double ZoomLevel
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

        public event EventHandler<ZoomLevelChangedEventArgs> ZoomLevelChanged;

        public Microsoft.VisualStudio.Text.Projection.IBufferGraph BufferGraph
        {
            get { throw new NotImplementedException(); }
        }

        public ITextCaret Caret
        {
            get { throw new NotImplementedException(); }
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public event EventHandler Closed;

        public void DisplayTextLineContainingBufferPosition(Microsoft.VisualStudio.Text.SnapshotPoint bufferPosition, double verticalDistance, ViewRelativePosition relativeTo, double? viewportWidthOverride, double? viewportHeightOverride)
        {
            throw new NotImplementedException();
        }

        public void DisplayTextLineContainingBufferPosition(Microsoft.VisualStudio.Text.SnapshotPoint bufferPosition, double verticalDistance, ViewRelativePosition relativeTo)
        {
            throw new NotImplementedException();
        }

        public Microsoft.VisualStudio.Text.SnapshotSpan GetTextElementSpan(Microsoft.VisualStudio.Text.SnapshotPoint point)
        {
            throw new NotImplementedException();
        }

        Microsoft.VisualStudio.Text.Formatting.ITextViewLine ITextView.GetTextViewLineContainingBufferPosition(Microsoft.VisualStudio.Text.SnapshotPoint bufferPosition)
        {
            throw new NotImplementedException();
        }

        public event EventHandler GotAggregateFocus;

        public bool HasAggregateFocus
        {
            get { throw new NotImplementedException(); }
        }

        public bool InLayout
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsClosed
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsMouseOverViewOrAdornments
        {
            get { throw new NotImplementedException(); }
        }

        public event EventHandler<TextViewLayoutChangedEventArgs> LayoutChanged;

        public double LineHeight
        {
            get { throw new NotImplementedException(); }
        }

        public event EventHandler LostAggregateFocus;

        public double MaxTextRightCoordinate
        {
            get { throw new NotImplementedException(); }
        }

        public event EventHandler<MouseHoverEventArgs> MouseHover;

        public IEditorOptions Options
        {
            get { throw new NotImplementedException(); }
        }

        public Microsoft.VisualStudio.Text.ITrackingSpan ProvisionalTextHighlight
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

        public void QueueSpaceReservationStackRefresh()
        {
            throw new NotImplementedException();
        }

        public ITextViewRoleSet Roles
        {
            get { throw new NotImplementedException(); }
        }

        public ITextSelection Selection
        {
            get { throw new NotImplementedException(); }
        }

        public Microsoft.VisualStudio.Text.ITextBuffer TextBuffer
        {
            get { throw new NotImplementedException(); }
        }

        public Microsoft.VisualStudio.Text.ITextDataModel TextDataModel
        {
            get { throw new NotImplementedException(); }
        }

        public Microsoft.VisualStudio.Text.ITextSnapshot TextSnapshot
        {
            get { return new MockTextSnapshot(); }
        }

        ITextViewLineCollection ITextView.TextViewLines
        {
            get { throw new NotImplementedException(); }
        }

        public ITextViewModel TextViewModel
        {
            get { throw new NotImplementedException(); }
        }

        public IViewScroller ViewScroller
        {
            get { throw new NotImplementedException(); }
        }

        public double ViewportBottom
        {
            get { throw new NotImplementedException(); }
        }

        public double ViewportHeight
        {
            get { throw new NotImplementedException(); }
        }

        public event EventHandler ViewportHeightChanged;

        public double ViewportLeft
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

        public event EventHandler ViewportLeftChanged;

        public double ViewportRight
        {
            get { throw new NotImplementedException(); }
        }

        public double ViewportTop
        {
            get { throw new NotImplementedException(); }
        }

        public double ViewportWidth
        {
            get { throw new NotImplementedException(); }
        }

        public event EventHandler ViewportWidthChanged;

        public Microsoft.VisualStudio.Text.ITextSnapshot VisualSnapshot
        {
            get { throw new NotImplementedException(); }
        }

        public Microsoft.VisualStudio.Utilities.PropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }

        internal void InvokeMouseHover(MouseHoverEventArgs e)
        {
            if (MouseHover != null)
            {
                MouseHover.Invoke(this, e);
            }
        }
    }
}
