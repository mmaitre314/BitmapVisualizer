using Microsoft.VisualStudio.Text.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitmapVisualizer_UnitTests
{
    class MockAdornmentLayer : IAdornmentLayer
    {
        internal bool WasAddAdornmentCalled;
        internal bool WasRemoveAdornmentCalled;

        public bool AddAdornment(Microsoft.VisualStudio.Text.SnapshotSpan visualSpan, object tag, System.Windows.UIElement adornment)
        {
            this.WasAddAdornmentCalled = true;
            return true;
        }

        public bool AddAdornment(AdornmentPositioningBehavior behavior, Microsoft.VisualStudio.Text.SnapshotSpan? visualSpan, object tag, System.Windows.UIElement adornment, AdornmentRemovedCallback removedCallback)
        {
            this.WasAddAdornmentCalled = true;
            return true;
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<IAdornmentLayerElement> Elements
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsEmpty
        {
            get { throw new NotImplementedException(); }
        }

        public double Opacity
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

        public void RemoveAdornment(System.Windows.UIElement adornment)
        {
            this.WasRemoveAdornmentCalled = true;
        }

        public void RemoveAdornmentsByTag(object tag)
        {
            throw new NotImplementedException();
        }

        public void RemoveAdornmentsByVisualSpan(Microsoft.VisualStudio.Text.SnapshotSpan visualSpan)
        {
            throw new NotImplementedException();
        }

        public void RemoveAllAdornments()
        {
            throw new NotImplementedException();
        }

        public void RemoveMatchingAdornments(Microsoft.VisualStudio.Text.SnapshotSpan visualSpan, Predicate<IAdornmentLayerElement> match)
        {
            throw new NotImplementedException();
        }

        public void RemoveMatchingAdornments(Predicate<IAdornmentLayerElement> match)
        {
            throw new NotImplementedException();
        }

        public IWpfTextView TextView
        {
            get { throw new NotImplementedException(); }
        }
    }
}
