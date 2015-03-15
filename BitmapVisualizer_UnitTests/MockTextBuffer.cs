using Microsoft.VisualStudio.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitmapVisualizer_UnitTests
{
    class MockTextBuffer : ITextBuffer
    {
        internal string Text;

        public MockTextBuffer(string text)
        {
            this.Text = text;
        }

        public void ChangeContentType(Microsoft.VisualStudio.Utilities.IContentType newContentType, object editTag)
        {
            throw new NotImplementedException();
        }

        public event EventHandler<TextContentChangedEventArgs> Changed;

        public event EventHandler<TextContentChangedEventArgs> ChangedHighPriority;

        public event EventHandler<TextContentChangedEventArgs> ChangedLowPriority;

        public event EventHandler<TextContentChangingEventArgs> Changing;

        public bool CheckEditAccess()
        {
            throw new NotImplementedException();
        }

        public Microsoft.VisualStudio.Utilities.IContentType ContentType
        {
            get { throw new NotImplementedException(); }
        }

        public event EventHandler<ContentTypeChangedEventArgs> ContentTypeChanged;

        public ITextEdit CreateEdit()
        {
            throw new NotImplementedException();
        }

        public ITextEdit CreateEdit(EditOptions options, int? reiteratedVersionNumber, object editTag)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyRegionEdit CreateReadOnlyRegionEdit()
        {
            throw new NotImplementedException();
        }

        public ITextSnapshot CurrentSnapshot
        {
            get { throw new NotImplementedException(); }
        }

        public ITextSnapshot Delete(Span deleteSpan)
        {
            throw new NotImplementedException();
        }

        public bool EditInProgress
        {
            get { throw new NotImplementedException(); }
        }

        public NormalizedSpanCollection GetReadOnlyExtents(Span span)
        {
            throw new NotImplementedException();
        }

        public ITextSnapshot Insert(int position, string text)
        {
            throw new NotImplementedException();
        }

        public bool IsReadOnly(Span span, bool isEdit)
        {
            throw new NotImplementedException();
        }

        public bool IsReadOnly(Span span)
        {
            throw new NotImplementedException();
        }

        public bool IsReadOnly(int position, bool isEdit)
        {
            throw new NotImplementedException();
        }

        public bool IsReadOnly(int position)
        {
            throw new NotImplementedException();
        }

        public event EventHandler PostChanged;

        public event EventHandler<SnapshotSpanEventArgs> ReadOnlyRegionsChanged;

        public ITextSnapshot Replace(Span replaceSpan, string replaceWith)
        {
            throw new NotImplementedException();
        }

        public void TakeThreadOwnership()
        {
            throw new NotImplementedException();
        }

        public Microsoft.VisualStudio.Utilities.PropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    }
}
