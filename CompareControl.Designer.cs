namespace FileIT
{
    partial class CompareControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonCommon = new System.Windows.Forms.RadioButton();
            this.radioButtonDiff = new System.Windows.Forms.RadioButton();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.checkBoxRecursive = new System.Windows.Forms.CheckBox();
            this.labelCompareDir = new System.Windows.Forms.Label();
            this.buttonCompareDir = new System.Windows.Forms.Button();
            this.labelCSV = new System.Windows.Forms.Label();
            this.buttonCSV = new System.Windows.Forms.Button();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.bgwCompare = new System.ComponentModel.BackgroundWorker();
            this.bgwExport = new System.ComponentModel.BackgroundWorker();
            this.toolTipCSV = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDiff = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCommon = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.radioButtonCommon);
            this.panel1.Controls.Add(this.radioButtonDiff);
            this.panel1.Controls.Add(this.buttonExport);
            this.panel1.Controls.Add(this.buttonCompare);
            this.panel1.Controls.Add(this.checkBoxRecursive);
            this.panel1.Controls.Add(this.labelCompareDir);
            this.panel1.Controls.Add(this.buttonCompareDir);
            this.panel1.Controls.Add(this.labelCSV);
            this.panel1.Controls.Add(this.buttonCSV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 146);
            this.panel1.TabIndex = 0;
            // 
            // radioButtonCommon
            // 
            this.radioButtonCommon.AutoSize = true;
            this.radioButtonCommon.ForeColor = System.Drawing.Color.White;
            this.radioButtonCommon.Location = new System.Drawing.Point(135, 115);
            this.radioButtonCommon.Name = "radioButtonCommon";
            this.radioButtonCommon.Size = new System.Drawing.Size(108, 19);
            this.radioButtonCommon.TabIndex = 9;
            this.radioButtonCommon.TabStop = true;
            this.radioButtonCommon.Text = "Show Common";
            this.toolTipCommon.SetToolTip(this.radioButtonCommon, "List files found on CSV");
            this.radioButtonCommon.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiff
            // 
            this.radioButtonDiff.AutoSize = true;
            this.radioButtonDiff.ForeColor = System.Drawing.Color.White;
            this.radioButtonDiff.Location = new System.Drawing.Point(18, 115);
            this.radioButtonDiff.Name = "radioButtonDiff";
            this.radioButtonDiff.Size = new System.Drawing.Size(111, 19);
            this.radioButtonDiff.TabIndex = 8;
            this.radioButtonDiff.TabStop = true;
            this.radioButtonDiff.Text = "Show Difference";
            this.toolTipDiff.SetToolTip(this.radioButtonDiff, "List files not found on CSV");
            this.radioButtonDiff.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonExport.FlatAppearance.BorderSize = 0;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExport.ForeColor = System.Drawing.Color.White;
            this.buttonExport.Location = new System.Drawing.Point(385, 111);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 7;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonCompare.FlatAppearance.BorderSize = 0;
            this.buttonCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCompare.ForeColor = System.Drawing.Color.White;
            this.buttonCompare.Location = new System.Drawing.Point(291, 111);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(75, 23);
            this.buttonCompare.TabIndex = 1;
            this.buttonCompare.Text = "Compare";
            this.buttonCompare.UseVisualStyleBackColor = false;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // checkBoxRecursive
            // 
            this.checkBoxRecursive.AutoSize = true;
            this.checkBoxRecursive.ForeColor = System.Drawing.Color.White;
            this.checkBoxRecursive.Location = new System.Drawing.Point(18, 90);
            this.checkBoxRecursive.Name = "checkBoxRecursive";
            this.checkBoxRecursive.Size = new System.Drawing.Size(76, 19);
            this.checkBoxRecursive.TabIndex = 1;
            this.checkBoxRecursive.Text = "Recursive";
            this.checkBoxRecursive.UseVisualStyleBackColor = true;
            // 
            // labelCompareDir
            // 
            this.labelCompareDir.BackColor = System.Drawing.Color.White;
            this.labelCompareDir.Location = new System.Drawing.Point(122, 50);
            this.labelCompareDir.Name = "labelCompareDir";
            this.labelCompareDir.Size = new System.Drawing.Size(804, 23);
            this.labelCompareDir.TabIndex = 4;
            this.labelCompareDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCompareDir
            // 
            this.buttonCompareDir.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonCompareDir.FlatAppearance.BorderSize = 0;
            this.buttonCompareDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompareDir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCompareDir.ForeColor = System.Drawing.Color.White;
            this.buttonCompareDir.Location = new System.Drawing.Point(18, 50);
            this.buttonCompareDir.Name = "buttonCompareDir";
            this.buttonCompareDir.Size = new System.Drawing.Size(98, 23);
            this.buttonCompareDir.TabIndex = 3;
            this.buttonCompareDir.Text = "Server Root";
            this.buttonCompareDir.UseVisualStyleBackColor = false;
            this.buttonCompareDir.Click += new System.EventHandler(this.buttonCompareDir_Click);
            // 
            // labelCSV
            // 
            this.labelCSV.BackColor = System.Drawing.Color.White;
            this.labelCSV.Location = new System.Drawing.Point(122, 21);
            this.labelCSV.Name = "labelCSV";
            this.labelCSV.Size = new System.Drawing.Size(804, 23);
            this.labelCSV.TabIndex = 2;
            this.labelCSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCSV
            // 
            this.buttonCSV.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonCSV.FlatAppearance.BorderSize = 0;
            this.buttonCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCSV.ForeColor = System.Drawing.Color.White;
            this.buttonCSV.Location = new System.Drawing.Point(18, 21);
            this.buttonCSV.Name = "buttonCSV";
            this.buttonCSV.Size = new System.Drawing.Size(98, 23);
            this.buttonCSV.TabIndex = 1;
            this.buttonCSV.Text = "Open CSV";
            this.toolTipCSV.SetToolTip(this.buttonCSV, "CSV file format is one column of file path");
            this.buttonCSV.UseVisualStyleBackColor = false;
            this.buttonCSV.Click += new System.EventHandler(this.buttonCSV_Click);
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewResult.CausesValidation = false;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.File});
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult.Location = new System.Drawing.Point(0, 185);
            this.dataGridViewResult.MultiSelect = false;
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.RowTemplate.Height = 25;
            this.dataGridViewResult.Size = new System.Drawing.Size(990, 379);
            this.dataGridViewResult.TabIndex = 1;
            // 
            // File
            // 
            this.File.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.File.HeaderText = "File";
            this.File.Name = "File";
            this.File.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.labelStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 39);
            this.panel2.TabIndex = 8;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(18, 11);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(38, 15);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "label1";
            // 
            // bgwCompare
            // 
            this.bgwCompare.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCompare_DoWork);
            this.bgwCompare.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCompare_RunWorkerCompleted);
            // 
            // bgwExport
            // 
            this.bgwExport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwExport_DoWork);
            this.bgwExport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwExport_RunWorkerCompleted);
            // 
            // toolTipCSV
            // 
            this.toolTipCSV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipDiff
            // 
            this.toolTipDiff.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipCommon
            // 
            this.toolTipCommon.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // CompareControl
            // 
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CompareControl";
            this.Size = new System.Drawing.Size(990, 564);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label labelCompareDir;
        private Button buttonCompareDir;
        private Label labelCSV;
        private Button buttonCSV;
        private CheckBox checkBoxRecursive;
        private Button buttonCompare;
        private Button buttonExport;
        private DataGridView dataGridViewResult;
        private Panel panel2;
        private Label labelStatus;
        private System.ComponentModel.BackgroundWorker bgwCompare;
        private RadioButton radioButtonCommon;
        private RadioButton radioButtonDiff;
        private DataGridViewTextBoxColumn File;
        private System.ComponentModel.BackgroundWorker bgwExport;
        private ToolTip toolTipCSV;
        private ToolTip toolTipCommon;
        private ToolTip toolTipDiff;
    }
}
