namespace XrmToolBox.AsynchronousSolutionImport
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
            this.SuspendLayout();
            // 
            // btnSelectSolution
            // 
            this.btnSelectSolution.Location = new System.Drawing.Point(15, 17);
            this.btnSelectSolution.Name = "btnSelectSolution";
            this.btnSelectSolution.Size = new System.Drawing.Size(131, 23);
            this.btnSelectSolution.TabIndex = 2;
            this.btnSelectSolution.Text = "Select Solution";
            this.btnSelectSolution.UseVisualStyleBackColor = true;
            this.btnSelectSolution.Click += new System.EventHandler(this.BtnSelectSolution_Click);
            // 
            // AsyncSolutionImportPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSelectSolution);
            this.Name = "AsyncSolutionImportPluginControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.AsyncSolutionImportPluginControl_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelectSolution;
    }
}