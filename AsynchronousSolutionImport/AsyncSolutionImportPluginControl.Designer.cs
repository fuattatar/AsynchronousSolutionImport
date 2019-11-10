namespace AsynchronousSolutionImport
{
    partial class AsyncSolutionImportPluginControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSelectSolution = new System.Windows.Forms.Button();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.cbPublishAfterImport = new System.Windows.Forms.CheckBox();
            this.txtSolutionPathText = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.gbAdvanceSettings = new System.Windows.Forms.GroupBox();
            this.cbSkipProductUpdateDependencies = new System.Windows.Forms.CheckBox();
            this.cbHoldingSolution = new System.Windows.Forms.CheckBox();
            this.cbConvertToManaged = new System.Windows.Forms.CheckBox();
            this.dgvAsyncImportJobs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.JobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FriendlyMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSettings.SuspendLayout();
            this.gbAdvanceSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsyncImportJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectSolution
            // 
            this.btnSelectSolution.Location = new System.Drawing.Point(267, 13);
            this.btnSelectSolution.Name = "btnSelectSolution";
            this.btnSelectSolution.Size = new System.Drawing.Size(103, 23);
            this.btnSelectSolution.TabIndex = 2;
            this.btnSelectSolution.Text = "Select Solution";
            this.btnSelectSolution.UseVisualStyleBackColor = true;
            this.btnSelectSolution.Click += new System.EventHandler(this.BtnSelectSolution_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.cbPublishAfterImport);
            this.gbSettings.Location = new System.Drawing.Point(13, 13);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(217, 50);
            this.gbSettings.TabIndex = 3;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // cbPublishAfterImport
            // 
            this.cbPublishAfterImport.AutoSize = true;
            this.cbPublishAfterImport.Location = new System.Drawing.Point(7, 20);
            this.cbPublishAfterImport.Name = "cbPublishAfterImport";
            this.cbPublishAfterImport.Size = new System.Drawing.Size(117, 17);
            this.cbPublishAfterImport.TabIndex = 0;
            this.cbPublishAfterImport.Text = "Publish After Import";
            this.cbPublishAfterImport.UseVisualStyleBackColor = true;
            // 
            // txtSolutionPathText
            // 
            this.txtSolutionPathText.Location = new System.Drawing.Point(391, 13);
            this.txtSolutionPathText.Name = "txtSolutionPathText";
            this.txtSolutionPathText.Size = new System.Drawing.Size(286, 20);
            this.txtSolutionPathText.TabIndex = 4;
            this.txtSolutionPathText.Text = "Select the solution you want to import";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(700, 13);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // gbAdvanceSettings
            // 
            this.gbAdvanceSettings.Controls.Add(this.cbSkipProductUpdateDependencies);
            this.gbAdvanceSettings.Controls.Add(this.cbHoldingSolution);
            this.gbAdvanceSettings.Controls.Add(this.cbConvertToManaged);
            this.gbAdvanceSettings.Location = new System.Drawing.Point(13, 73);
            this.gbAdvanceSettings.Name = "gbAdvanceSettings";
            this.gbAdvanceSettings.Size = new System.Drawing.Size(217, 100);
            this.gbAdvanceSettings.TabIndex = 6;
            this.gbAdvanceSettings.TabStop = false;
            this.gbAdvanceSettings.Text = "Advance Settings";
            // 
            // cbSkipProductUpdateDependencies
            // 
            this.cbSkipProductUpdateDependencies.AutoSize = true;
            this.cbSkipProductUpdateDependencies.Location = new System.Drawing.Point(7, 67);
            this.cbSkipProductUpdateDependencies.Name = "cbSkipProductUpdateDependencies";
            this.cbSkipProductUpdateDependencies.Size = new System.Drawing.Size(197, 17);
            this.cbSkipProductUpdateDependencies.TabIndex = 9;
            this.cbSkipProductUpdateDependencies.Text = "Skip Product Update Dependencies";
            this.cbSkipProductUpdateDependencies.UseVisualStyleBackColor = true;
            // 
            // cbHoldingSolution
            // 
            this.cbHoldingSolution.AutoSize = true;
            this.cbHoldingSolution.Location = new System.Drawing.Point(7, 43);
            this.cbHoldingSolution.Name = "cbHoldingSolution";
            this.cbHoldingSolution.Size = new System.Drawing.Size(103, 17);
            this.cbHoldingSolution.TabIndex = 8;
            this.cbHoldingSolution.Text = "Holding Solution";
            this.cbHoldingSolution.UseVisualStyleBackColor = true;
            // 
            // cbConvertToManaged
            // 
            this.cbConvertToManaged.AutoSize = true;
            this.cbConvertToManaged.Location = new System.Drawing.Point(7, 19);
            this.cbConvertToManaged.Name = "cbConvertToManaged";
            this.cbConvertToManaged.Size = new System.Drawing.Size(127, 17);
            this.cbConvertToManaged.TabIndex = 7;
            this.cbConvertToManaged.Text = "Convert To Managed";
            this.cbConvertToManaged.UseVisualStyleBackColor = true;
            // 
            // dgvAsyncImportJobs
            // 
            this.dgvAsyncImportJobs.AllowUserToAddRows = false;
            this.dgvAsyncImportJobs.AllowUserToDeleteRows = false;
            this.dgvAsyncImportJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsyncImportJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobName,
            this.CreatedOn,
            this.StartedOn,
            this.CompletedOn,
            this.StatusCode,
            this.FriendlyMessage,
            this.Message});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsyncImportJobs.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsyncImportJobs.Location = new System.Drawing.Point(267, 116);
            this.dgvAsyncImportJobs.Name = "dgvAsyncImportJobs";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsyncImportJobs.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsyncImportJobs.Size = new System.Drawing.Size(1003, 331);
            this.dgvAsyncImportJobs.TabIndex = 7;
            this.dgvAsyncImportJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAsyncImportJobs_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "System Jobs";
            // 
            // JobName
            // 
            this.JobName.Frozen = true;
            this.JobName.HeaderText = "JobName";
            this.JobName.Name = "JobName";
            this.JobName.Width = 120;
            // 
            // CreatedOn
            // 
            this.CreatedOn.Frozen = true;
            this.CreatedOn.HeaderText = "CreatedOn";
            this.CreatedOn.MinimumWidth = 20;
            this.CreatedOn.Name = "CreatedOn";
            this.CreatedOn.Width = 120;
            // 
            // StartedOn
            // 
            this.StartedOn.Frozen = true;
            this.StartedOn.HeaderText = "Started On";
            this.StartedOn.MinimumWidth = 20;
            this.StartedOn.Name = "StartedOn";
            this.StartedOn.Width = 120;
            // 
            // CompletedOn
            // 
            this.CompletedOn.Frozen = true;
            this.CompletedOn.HeaderText = "Completed On";
            this.CompletedOn.MinimumWidth = 20;
            this.CompletedOn.Name = "CompletedOn";
            this.CompletedOn.Width = 120;
            // 
            // StatusCode
            // 
            this.StatusCode.Frozen = true;
            this.StatusCode.HeaderText = "Status Code";
            this.StatusCode.MinimumWidth = 8;
            this.StatusCode.Name = "StatusCode";
            // 
            // FriendlyMessage
            // 
            this.FriendlyMessage.Frozen = true;
            this.FriendlyMessage.HeaderText = "FriendlyMessage";
            this.FriendlyMessage.Name = "FriendlyMessage";
            // 
            // Message
            // 
            this.Message.Frozen = true;
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.Width = 400;
            // 
            // AsyncSolutionImportPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAsyncImportJobs);
            this.Controls.Add(this.gbAdvanceSettings);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtSolutionPathText);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.btnSelectSolution);
            this.Name = "AsyncSolutionImportPluginControl";
            this.Size = new System.Drawing.Size(1270, 450);
            this.Load += new System.EventHandler(this.AsyncSolutionImportPluginControl_Load);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbAdvanceSettings.ResumeLayout(false);
            this.gbAdvanceSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsyncImportJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectSolution;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.CheckBox cbPublishAfterImport;
        private System.Windows.Forms.TextBox txtSolutionPathText;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox gbAdvanceSettings;
        private System.Windows.Forms.CheckBox cbConvertToManaged;
        private System.Windows.Forms.CheckBox cbHoldingSolution;
        private System.Windows.Forms.CheckBox cbSkipProductUpdateDependencies;
        private System.Windows.Forms.DataGridView dgvAsyncImportJobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompletedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FriendlyMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
    }
}