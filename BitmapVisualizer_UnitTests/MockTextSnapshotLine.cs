using Microsoft.VisualStudio.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitmapVisualizer_UnitTests
{
    class MockTextSnapshotLine : ITextSnapshotLine
    {
        private MockTextBuffer m_text;
        private int m_position;

        internal MockTextSnapshotLine(MockTextBuffer m_text, int position)
        {
            this.m_text = m_text;
            this.m_position = position;
        }

        public SnapshotPoint End
        {
            get { throw new NotImplementedException(); }
        }

        public SnapshotPoint EndIncludingLineBreak
        {
            get { throw new NotImplementedException(); }
        }

        public SnapshotSpan Extent
        {
            get { throw new NotImplementedException(); }
        }

        public SnapshotSpan ExtentIncludingLineBreak
        {
            get { throw new NotImplementedException(); }
        }

        public string GetLineBreakText()
        {
            throw new NotImplementedException();
        }

        public string GetText()
        {
            return m_text.Text;
        }

        public string GetTextIncludingLineBreak()
        {
            throw new NotImplementedException();
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

        public int LineNumber
        {
            get { throw new NotImplementedException(); }
        }

        public ITextSnapshot Snapshot
        {
            get { throw new NotImplementedException(); }
        }

        public SnapshotPoint Start
        {
            get { return new SnapshotPoint(new MockTextSnapshot(m_text), m_position); }
        }
    }
}
