using Microsoft.VisualStudio.Text.Formatting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitmapVisualizer_UnitTests
{
    class MockWpfTextViewLine : IWpfTextViewLine
    {
        public System.Windows.Media.TextFormatting.TextRunProperties GetCharacterFormatting(Microsoft.VisualStudio.Text.SnapshotPoint bufferPosition)
        {
            throw new NotImplementedException();
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<System.Windows.Media.TextFormatting.TextLine> TextLines
        {
            get { throw new NotImplementedException(); }
        }

        public System.Windows.Rect VisibleArea
        {
            get { throw new NotImplementedException(); }
        }

        public double Baseline
        {
            get { throw new NotImplementedException(); }
        }

        public double Bottom
        {
            get { throw new NotImplementedException(); }
        }

        public TextViewLineChange Change
        {
            get { throw new NotImplementedException(); }
        }

        public bool ContainsBufferPosition(Microsoft.VisualStudio.Text.SnapshotPoint bufferPosition)
        {
            throw new NotImplementedException();
        }

        public LineTransform DefaultLineTransform
        {
            get { throw new NotImplementedException(); }
        }

        public double DeltaY
        {
            get { throw new NotImplementedException(); }
        }

        public Microsoft.VisualStudio.Text.SnapshotPoint End
        {
            get { throw new NotImplementedException(); }
        }

        public Microsoft.VisualStudio.Text.SnapshotPoint EndIncludingLineBreak
        {
            get { throw new NotImplementedException(); }
        }

        public double EndOfLineWidth
        {
            get { throw new NotImplementedException(); }
        }

        public Microsoft.VisualStudio.Text.SnapshotSpan Extent
        {
            get { throw new NotImplementedException(); }
        }

        public Microsoft.VisualStudio.Text.IMappingSpan ExtentAsMappingSpan
        {
            get { throw new NotImplementedException(); }
        }

        public Microsoft.VisualStudio.Text.SnapshotSpan ExtentIncludingLineBreak
        {
            get { throw new NotImplementedException(); }
        }

        public Microsoft.VisualStudio.Text.IMappingSpan ExtentIncludingLineBreakAsMappingSpan
        {
            get { throw new NotImplementedException(); }
        }

        public TextBounds? GetAdornmentBounds(object identityTag)
        {
            throw new NotImplementedException();
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<object> GetAdornmentTags(object providerTag)
        {
            throw new NotImplementedException();
        }

        public Microsoft.VisualStudio.Text.SnapshotPoint? GetBufferPositionFromXCoordinate(double xCoordinate)
        {
            throw new NotImplementedException();
        }

        public Microsoft.VisualStudio.Text.SnapshotPoint? GetBufferPositionFromXCoordinate(double xCoordinate, bool textOnly)
        {
            throw new NotImplementedException();
        }

        public TextBounds GetCharacterBounds(Microsoft.VisualStudio.Text.VirtualSnapshotPoint bufferPosition)
        {
            throw new NotImplementedException();
        }

        public TextBounds GetCharacterBounds(Microsoft.VisualStudio.Text.SnapshotPoint bufferPosition)
        {
            throw new NotImplementedException();
        }

        public TextBounds GetExtendedCharacterBounds(Microsoft.VisualStudio.Text.VirtualSnapshotPoint bufferPosition)
        {
            throw new NotImplementedException();
        }

        public TextBounds GetExtendedCharacterBounds(Microsoft.VisualStudio.Text.SnapshotPoint bufferPosition)
        {
            throw new NotImplementedException();
        }

        public Microsoft.VisualStudio.Text.VirtualSnapshotPoint GetInsertionBufferPositionFromXCoordinate(double xCoordinate)
        {
            throw new NotImplementedException();
        }

        public System.Collections.ObjectModel.Collection<TextBounds> GetNormalizedTextBounds(Microsoft.VisualStudio.Text.SnapshotSpan bufferSpan)
        {
            throw new NotImplementedException();
        }

        public Microsoft.VisualStudio.Text.SnapshotSpan GetTextElementSpan(Microsoft.VisualStudio.Text.SnapshotPoint bufferPosition)
        {
            throw new NotImplementedException();
        }

        public Microsoft.VisualStudio.Text.VirtualSnapshotPoint GetVirtualBufferPositionFromXCoordinate(double xCoordinate)
        {
            throw new NotImplementedException();
        }

        public double Height
        {
            get { throw new NotImplementedException(); }
        }

        public object IdentityTag
        {
            get { throw new NotImplementedException(); }
        }

        public bool IntersectsBufferSpan(Microsoft.VisualStudio.Text.SnapshotSpan bufferSpan)
        {
            throw new NotImplementedException();
        }

        public bool IsFirstTextViewLineForSnapshotLine
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsLastTextViewLineForSnapshotLine
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsValid
        {
            get { throw new NotImplementedException(); }
        }

        public double Left
        {
            get { throw new NotImplementedException(); }
        }

        public int Length
        {
            get { throw new NotImplementedException(); }
        }

        public int LengthIncludingLineBreak
        {
            get { throw new NotImplementedException(); }
        }

        public int LineBreakLength
        {
            get { throw new NotImplementedException(); }
        }

        public LineTransform LineTransform
        {
            get { throw new NotImplementedException(); }
        }

        public double Right
        {
            get { throw new NotImplementedException(); }
        }

        public Microsoft.VisualStudio.Text.ITextSnapshot Snapshot
        {
            get { throw new NotImplementedException(); }
        }

        public Microsoft.VisualStudio.Text.SnapshotPoint Start
        {
            get { throw new NotImplementedException(); }
        }

        public double TextBottom
        {
            get { throw new NotImplementedException(); }
        }

        public double TextHeight
        {
            get { throw new NotImplementedException(); }
        }

        public double TextLeft
        {
            get { throw new NotImplementedException(); }
        }

        public double TextRight
        {
            get { throw new NotImplementedException(); }
        }

        public double TextTop
        {
            get { throw new NotImplementedException(); }
        }

        public double TextWidth
        {
            get { throw new NotImplementedException(); }
        }

        public double Top
        {
            get { return 0.0; }
        }

        public double VirtualSpaceWidth
        {
            get { throw new NotImplementedException(); }
        }

        public VisibilityState VisibilityState
        {
            get { throw new NotImplementedException(); }
        }

        public double Width
        {
            get { throw new NotImplementedException(); }
        }
    }
}
