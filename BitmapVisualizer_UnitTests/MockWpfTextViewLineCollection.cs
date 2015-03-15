using Microsoft.VisualStudio.Text.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace BitmapVisualizer_UnitTests
{
    class MockWpfTextViewLineCollection : IWpfTextViewLineCollection
    {
        public Microsoft.VisualStudio.Text.Formatting.IWpfTextViewLine FirstVisibleLine
        {
            get { throw new NotImplementedException(); }
        }

        public System.Windows.Media.Geometry GetLineMarkerGeometry(Microsoft.VisualStudio.Text.SnapshotSpan bufferSpan, bool clipToViewport, System.Windows.Thickness padding)
        {
            throw new NotImplementedException();
        }

        public System.Windows.Media.Geometry GetLineMarkerGeometry(Microsoft.VisualStudio.Text.SnapshotSpan bufferSpan)
        {
            throw new NotImplementedException();
        }

        public System.Windows.Media.Geometry GetMarkerGeometry(Microsoft.VisualStudio.Text.SnapshotSpan bufferSpan)
        {
            return new RectangleGeometry(new Rect(0.0, 0.0, 100.0, 100.0));
        }

        public System.Windows.Media.Geometry GetMarkerGeometry(Microsoft.VisualStudio.Text.SnapshotSpan bufferSpan, bool clipToViewport, System.Windows.Thickness padding)
        {
            throw new NotImplementedException();
        }

        public System.Windows.Media.Geometry GetTextMarkerGeometry(Microsoft.VisualStudio.Text.SnapshotSpan bufferSpan, bool clipToViewport, System.Windows.Thickness padding)
        {
            throw new NotImplementedException();
        }

        public System.Windows.Media.Geometry GetTextMarkerGeometry(Microsoft.VisualStudio.Text.SnapshotSpan bufferSpan)
        {
            throw new NotImplementedException();
        }

        public Microsoft.VisualStudio.Text.Formatting.IWpfTextViewLine GetTextViewLineContainingBufferPosition(Microsoft.VisualStudio.Text.SnapshotPoint bufferPosition)
        {
            throw new NotImplementedException();
        }

        public Microsoft.VisualStudio.Text.Formatting.IWpfTextViewLine LastVisibleLine
        {
            get { throw new NotImplementedException(); }
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.VisualStudio.Text.Formatting.IWpfTextViewLine> WpfTextViewLines
        {
            get { throw new NotImplementedException(); }
        }

        public Microsoft.VisualStudio.Text.Formatting.IWpfTextViewLine this[int index]
        {
            get { throw new NotImplementedException(); }
        }

        public bool ContainsBufferPosition(Microsoft.VisualStudio.Text.SnapshotPoint bufferPosition)
        {
            throw new NotImplementedException();
        }

        Microsoft.VisualStudio.Text.Formatting.ITextViewLine ITextViewLineCollection.FirstVisibleLine
        {
            get { throw new NotImplementedException(); }
        }

        public Microsoft.VisualStudio.Text.SnapshotSpan FormattedSpan
        {
            get { throw new NotImplementedException(); }
        }

        public Microsoft.VisualStudio.Text.Formatting.TextBounds GetCharacterBounds(Microsoft.VisualStudio.Text.SnapshotPoint bufferPosition)
        {
            throw new NotImplementedException();
        }

        public int GetIndexOfTextLine(Microsoft.VisualStudio.Text.Formatting.ITextViewLine textLine)
        {
            throw new NotImplementedException();
        }

        public System.Collections.ObjectModel.Collection<Microsoft.VisualStudio.Text.Formatting.TextBounds> GetNormalizedTextBounds(Microsoft.VisualStudio.Text.SnapshotSpan bufferSpan)
        {
            throw new NotImplementedException();
        }

        public Microsoft.VisualStudio.Text.SnapshotSpan GetTextElementSpan(Microsoft.VisualStudio.Text.SnapshotPoint bufferPosition)
        {
            throw new NotImplementedException();
        }

        Microsoft.VisualStudio.Text.Formatting.ITextViewLine ITextViewLineCollection.GetTextViewLineContainingBufferPosition(Microsoft.VisualStudio.Text.SnapshotPoint bufferPosition)
        {
            throw new NotImplementedException();
        }

        public Microsoft.VisualStudio.Text.Formatting.ITextViewLine GetTextViewLineContainingYCoordinate(double y)
        {
            throw new NotImplementedException();
        }

        public System.Collections.ObjectModel.Collection<Microsoft.VisualStudio.Text.Formatting.ITextViewLine> GetTextViewLinesIntersectingSpan(Microsoft.VisualStudio.Text.SnapshotSpan bufferSpan)
        {
            throw new NotImplementedException();
        }

        public bool IntersectsBufferSpan(Microsoft.VisualStudio.Text.SnapshotSpan bufferSpan)
        {
            throw new NotImplementedException();
        }

        public bool IsValid
        {
            get { throw new NotImplementedException(); }
        }

        Microsoft.VisualStudio.Text.Formatting.ITextViewLine ITextViewLineCollection.LastVisibleLine
        {
            get { throw new NotImplementedException(); }
        }

        public int IndexOf(Microsoft.VisualStudio.Text.Formatting.ITextViewLine item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, Microsoft.VisualStudio.Text.Formatting.ITextViewLine item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        Microsoft.VisualStudio.Text.Formatting.ITextViewLine IList<Microsoft.VisualStudio.Text.Formatting.ITextViewLine>.this[int index]
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

        public void Add(Microsoft.VisualStudio.Text.Formatting.ITextViewLine item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Microsoft.VisualStudio.Text.Formatting.ITextViewLine item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Microsoft.VisualStudio.Text.Formatting.ITextViewLine[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(Microsoft.VisualStudio.Text.Formatting.ITextViewLine item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Microsoft.VisualStudio.Text.Formatting.ITextViewLine> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
