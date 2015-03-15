using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMaitre.BitmapVisualizer
{
    [Export(typeof(IWpfTextViewCreationListener))]
    [ContentType("code")]
    [TextViewRole(PredefinedTextViewRoles.Document)]
    internal sealed class BitmapVisualizerFactory : IWpfTextViewCreationListener
    {
        private DTE2 m_dte;

        [Export(typeof(AdornmentLayerDefinition))]
        [Name(BitmapVisualizer.AdornmentLayerName)]
        [Order(After = PredefinedAdornmentLayers.Text)]
        internal AdornmentLayerDefinition editorAdornmentLayer = null;

        BitmapVisualizerFactory()
        {
            Logger.EnterMethod(this);
            
            m_dte = (DTE2)ServiceProvider.GlobalProvider.GetService(typeof(DTE));

            Logger.ExitMethod(this);
        }

        public void TextViewCreated(IWpfTextView view)
        {
            Logger.EnterMethod(this);

            view.Properties.GetOrCreateSingletonProperty<BitmapVisualizer>(() => new BitmapVisualizer(m_dte.Debugger, view));

            Logger.ExitMethod(this);
        }
    }
}
