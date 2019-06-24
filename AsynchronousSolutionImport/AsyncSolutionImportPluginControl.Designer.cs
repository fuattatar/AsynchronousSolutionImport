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
            this.btnSelectSolution = new System.Windows.Forms.Button();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.cbPublishAfterImport = new System.Windows.Forms.CheckBox();
            this.txtSolutionPathText = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.gbAdvanceSettings = new System.Windows.Forms.GroupBox();
            this.cbConvertToManaged = new System.Windows.Forms.CheckBox();
            this.cbHoldingSolution = new System.Windows.Forms.CheckBox();
            this.cbSkipProductUpdateDependencies = new System.Windows.Forms.CheckBox();
            this.gbSettings.SuspendLayout();
            this.gbAdvanceSettings.SuspendLayout();
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
            // AsyncSolutionImportPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAdvanceSettings);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtSolutionPathText);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.btnSelectSolution);
            this.Name = "AsyncSolutionImportPluginControl";
            this.Size = new System.Drawing.Size(830, 450);
            this.Load += new System.EventHandler(this.AsyncSolutionImportPluginControl_Load);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbAdvanceSettings.ResumeLayout(false);
            this.gbAdvanceSettings.PerformLayout();
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
    }
}