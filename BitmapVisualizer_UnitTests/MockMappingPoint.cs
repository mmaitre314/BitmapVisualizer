using Microsoft.VisualStudio.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitmapVisualizer_UnitTests
{
    class MockMappingPoint : IMappingPoint
    {
        readonly MockTextBuffer m_text;

        internal MockMappingPoint(string text)
        {
            m_text = new MockTextBuffer(text);
        }

        public ITextBuffer AnchorBuffer
        {
            get { return m_text; }
        }

        public Microsoft.VisualStudio.Text.Projection.IBufferGraph BufferGraph
        {
            get { throw new NotImplementedException(); }
        }

        public SnapshotPoint? GetInsertionPoint(Predicate<ITextBuffer> match)
        {
            throw new NotImplementedException();
        }

        public SnapshotPoint? GetPoint(Predicate<ITextBuffer> match, PositionAffinity affinity)
        {
            throw new NotImplementedException();
        }

        public SnapshotPoint? GetPoint(ITextSnapshot targetSnapshot, PositionAffinity affinity)
        {
            throw new NotImplementedException();
        }

        public SnapshotPoint? GetPoint(ITextBuffer targetBuffer, PositionAffinity affinity)
        {
            return new SnapshotPoint(new MockTextSnapshot(m_text), 0);
        }
    }
}
