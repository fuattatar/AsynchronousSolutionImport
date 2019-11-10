using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace AsynchronousSolutionImport
{
    public partial class AsyncSolutionImportPluginControl : PluginControlBase
    {
        private const string DEFAULT_TEXT = "Select the solution you want to import";
        private const string ASYNCOPERATION = "asyncoperation";
        private const string MESSAGE_INCCORRECT_PATH = "Incorrect path. Please select solution zip file";
        private const string MESSAGE_IMPORT_STARTED = "Solution import process is started. Check it's progress in Settings>System Job ";
        private const string MESSAGE_PLEASE_SELECT_SOLUTION = "Please select the solution zip file";
        private const string MESSAGE_UPLOADING_SOLUTION = "Uploading solution";
        OpenFileDialog openFileDialog = new OpenFileDialog();

        enum JobStatus
        {
            Succeeded = 30,
            Failed = 31,
            Canceled = 32,
            InProgress = 20,
            Pausing = 21,
            Cancelling = 22,
            WaitingForResources = 0,
            Waiting = 10
        }

        public AsyncSolutionImportPluginControl()
        {
            InitializeComponent();
        }

        private void AsyncSolutionImportPluginControl_Load(object sender, EventArgs e)
        {
            InitTimer();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void BtnSelectSolution_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Zip Files|*.zip";
            openFileDialog.Title = MESSAGE_PLEASE_SELECT_SOLUTION;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = openFileDialog.SafeFileName;

                txtSolutionPathText.Text = filePath;
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            var solutionPath = txtSolutionPathText.Text;

            if (string.IsNullOrEmpty(solutionPath) || solutionPath == DEFAULT_TEXT)
            {
                MessageBox.Show(MESSAGE_INCCORRECT_PATH);

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

            InitTimer();
        }

        private void RunImportRequest(ExecuteAsyncRequest request)
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = MESSAGE_UPLOADING_SOLUTION,
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
                        MessageBox.Show(MESSAGE_IMPORT_STARTED);
                    }
                }
            });
        }

        private static ExecuteAsyncRequest PrepareImportRequest(string filePath, params bool[] values)
        {

            //ParameterCollection parameterCollection = new ParameterCollection();
            //parameterCollection.Add(new System.Collections.Generic.KeyValuePair<string, object>("name", "test"));


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

        private Timer timer1;

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 20000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dgvAsyncImportJobs.Rows.Clear();
            EntityCollection systemjobs = RetrieveSystemImportJobs();
            AddImportJobsToGrid(systemjobs);
        }

        private void AddImportJobsToGrid(EntityCollection systemjobs)
        {
            foreach (var job in systemjobs.Entities)
            {
                string jobName = job.Attributes["name"].ToString();
                var createdOn = Convert.ToString(job.GetAttributeValue<DateTime?>("createdon"));
                var startedOn = Convert.ToString(job.GetAttributeValue<DateTime?>("startedon"));
                var completedOn = Convert.ToString(job.GetAttributeValue<DateTime?>("completedon"));
                var statusCode = Enum.GetName(typeof(JobStatus), ((OptionSetValue)job.Attributes["statuscode"]).Value);
                string friendlyMessage = job.GetAttributeValue<string>("friendlymessage");
                string message = job.GetAttributeValue<string>("message");


                string[] row = {
                    jobName,
                    createdOn,
                    startedOn,
                    completedOn,
                    statusCode,
                    friendlyMessage,
                    message
                };

                dgvAsyncImportJobs.Rows.Add(row);
            }

            dgvAsyncImportJobs.AutoResizeColumns();
            dgvAsyncImportJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private EntityCollection RetrieveSystemImportJobs()
        {
            QueryExpression systemJobsQueryExpression = new QueryExpression
            {
                EntityName = ASYNCOPERATION,
                ColumnSet = new ColumnSet("name", "createdon", "completedon", "regardingobjectid", "asyncoperationid", "startedon", "messagename", "statuscode", "friendlymessage", "message"),
                Criteria = new FilterExpression
                {
                    Conditions = {
                        new ConditionExpression
                        {
                            AttributeName = "name",
                            Operator = ConditionOperator.Equal,
                            Values = { "ImportSolution" }
                        }
                     }
                },
            };

            systemJobsQueryExpression.AddOrder("createdon", OrderType.Descending);
            systemJobsQueryExpression.PageInfo.PageNumber = 1;
            systemJobsQueryExpression.PageInfo.Count = 10;

            var systemjobs = Service.RetrieveMultiple(systemJobsQueryExpression);

            return systemjobs;
        }

        private void DgvAsyncImportJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
