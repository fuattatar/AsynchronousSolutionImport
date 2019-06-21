using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.IO;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace XrmToolBox.AsynchronousSolutionImport
{
    public partial class AsyncSolutionImportPluginControl : PluginControlBase
    {
        public AsyncSolutionImportPluginControl()
        {
            InitializeComponent();
        }

        private void AsyncSolutionImportPluginControl_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        OpenFileDialog openFileDialog = new OpenFileDialog();

        private void BtnSelectSolution_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Zip Files|*.zip";
            openFileDialog.Title = "Please select the solution zip file";

            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = openFileDialog.SafeFileName;

                ExecuteAsyncRequest importRequest = PrepareImportRequest(filePath);

                RunImportRequest(importRequest);
            }
        }

        private void RunImportRequest(ExecuteAsyncRequest request)
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Uploading solution",
                Work = (worker, args) =>
                {
                    args.Result = (ExecuteAsyncResponse)Service.Execute(request);
                },

                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    var result = args.Result;

                    if (result != null)
                    {
                        MessageBox.Show("Solution is imported and published");
                    }
                }
            });
        }

        private static ExecuteAsyncRequest PrepareImportRequest(string filePath)
        {
            ExecuteAsyncRequest request = new ExecuteAsyncRequest
            {
                Request = new ImportSolutionRequest
                {
                    CustomizationFile = File.ReadAllBytes(filePath),
                    PublishWorkflows = true,
                    OverwriteUnmanagedCustomizations = true,
                }
            };

            return request;
        }
    }
}
