using System.ComponentModel.Composition;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace AsynchronousSolutionImport
{
    [Export(typeof(IXrmToolBoxPlugin)),
    ExportMetadata("BackgroundColor", "MediumBlue"),
    ExportMetadata("PrimaryFontColor", "White"),
    ExportMetadata("SecondaryFontColor", "LightGray"),
    ExportMetadata("SmallImageBase64", null),
    ExportMetadata("BigImageBase64", null),
    ExportMetadata("Name", "Async Solutin Import"),
    ExportMetadata("Description", "Dynamics Crm Asynchronous Solution Importy")]
    public class AsyncSolutionImportPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new AsyncSolutionImportPluginControl();
        }
    }
}
