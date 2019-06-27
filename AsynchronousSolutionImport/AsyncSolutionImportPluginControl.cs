using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.IO;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace AsynchronousSolutionImport
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

                txtSolutionPathText.Text = filePath;
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
                        MessageBox.Show("Solution import process is started. Check it's progress in Settings>System Job ");
                    }
                }
            });
        }

        private static ExecuteAsyncRequest PrepareImportRequest(string filePath, params bool[] values)
        {
            ExecuteAsyncRequest request = new ExecuteAsyncRequest
            {
                Request = new ImportSolutionRequest
                {
                    CustomizationFile = File.ReadAllBytes(filePath),
                    OverwriteUnmanagedCustomizations = true,
                    PublishWorkflows = values[0],
                    ConvertToManaged = values[1],
                    HoldingSolution = values[2],
                    SkipProductUpdateDependencies = values[3]
                    
                    
                }
            };

            return request;
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            var solutionPath = txtSolutionPathText.Text;

            if (string.IsNullOrEmpty(solutionPath))
            {
                MessageBox.Show("Incorrect path. Please select solution zip file");

                return;
            }

            ExecuteAsyncRequest importRequest = PrepareImportRequest
                (
                solutionPath,
                cbPublishAfterImport.Checked,
                cbConvertToManaged.Checked,
                cbHoldingSolution.Checked,
                cbSkipProductUpdateDependencies.Checked

                );

            RunImportRequest(importRequest);
        }
    }
}
