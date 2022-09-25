namespace FileIT
{
    partial class HomeControl
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
            this.panelHome = new System.Windows.Forms.Panel();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelSource = new System.Windows.Forms.Label();
            this.buttonDestination = new System.Windows.Forms.Button();
            this.buttonSource = new System.Windows.Forms.Button();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.labelProgressOf = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panelControls = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.checkBoxRecursive = new System.Windows.Forms.CheckBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.checkBoxTo = new System.Windows.Forms.CheckBox();
            this.checkBoxFrom = new System.Windows.Forms.CheckBox();
            this.comboBoxActionType = new System.Windows.Forms.ComboBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panelHome.SuspendLayout();
            this.panelProgress.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.labelDestination);
            this.panelHome.Controls.Add(this.labelSource);
            this.panelHome.Controls.Add(this.buttonDestination);
            this.panelHome.Controls.Add(this.buttonSource);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(990, 89);
            this.panelHome.TabIndex = 0;
            // 
            // labelDestination
            // 
            this.labelDestination.BackColor = System.Drawing.Color.White;
            this.labelDestination.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDestination.Location = new System.Drawing.Point(148, 46);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelDestination.Size = new System.Drawing.Size(832, 32);
            this.labelDestination.TabIndex = 3;
            // 
            // labelSource
            // 
            this.labelSource.BackColor = System.Drawing.Color.White;
            this.labelSource.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSource.Location = new System.Drawing.Point(148, 8);
            this.labelSource.Name = "labelSource";
            this.labelSource.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelSource.Size = new System.Drawing.Size(832, 32);
            this.labelSource.TabIndex = 2;
            // 
            // buttonDestination
            // 
            this.buttonDestination.AutoSize = true;
            this.buttonDestination.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDestination.FlatAppearance.BorderSize = 0;
            this.buttonDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDestination.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDestination.ForeColor = System.Drawing.Color.White;
            this.buttonDestination.Location = new System.Drawing.Point(8, 46);
            this.buttonDestination.Name = "buttonDestination";
            this.buttonDestination.Size = new System.Drawing.Size(136, 32);
            this.buttonDestination.TabIndex = 1;
            this.buttonDestination.Text = "Destination";
            this.buttonDestination.UseVisualStyleBackColor = false;
            this.buttonDestination.Click += new System.EventHandler(this.buttonDestination_Click);
            // 
            // buttonSource
            // 
            this.buttonSource.AutoSize = true;
            this.buttonSource.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSource.FlatAppearance.BorderSize = 0;
            this.buttonSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSource.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSource.ForeColor = System.Drawing.Color.White;
            this.buttonSource.Location = new System.Drawing.Point(8, 8);
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.Size = new System.Drawing.Size(136, 32);
            this.buttonSource.TabIndex = 0;
            this.buttonSource.Text = "Source";
            this.buttonSource.UseVisualStyleBackColor = false;
            this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);
            // 
            // panelProgress
            // 
            this.panelProgress.Controls.Add(this.labelProgressOf);
            this.panelProgress.Controls.Add(this.progressBar);
            this.panelProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProgress.Location = new System.Drawing.Point(0, 89);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(990, 60);
            this.panelProgress.TabIndex = 1;
            // 
            // labelProgressOf
            // 
            this.labelProgressOf.AutoSize = true;
            this.labelProgressOf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProgressOf.ForeColor = System.Drawing.Color.White;
            this.labelProgressOf.Location = new System.Drawing.Point(8, 37);
            this.labelProgressOf.Name = "labelProgressOf";
            this.labelProgressOf.Size = new System.Drawing.Size(26, 15);
            this.labelProgressOf.TabIndex = 1;
            this.labelProgressOf.Text = "0/0";
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBar.Location = new System.Drawing.Point(8, 6);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(972, 28);
            this.progressBar.TabIndex = 0;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.label1);
            this.panelControls.Controls.Add(this.buttonExecute);
            this.panelControls.Controls.Add(this.checkBoxRecursive);
            this.panelControls.Controls.Add(this.dateTimePickerTo);
            this.panelControls.Controls.Add(this.dateTimePickerFrom);
            this.panelControls.Controls.Add(this.checkBoxTo);
            this.panelControls.Controls.Add(this.checkBoxFrom);
            this.panelControls.Controls.Add(this.comboBoxActionType);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 149);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(990, 61);
            this.panelControls.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose Action";
            // 
            // buttonExecute
            // 
            this.buttonExecute.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonExecute.FlatAppearance.BorderSize = 0;
            this.buttonExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExecute.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExecute.ForeColor = System.Drawing.Color.White;
            this.buttonExecute.Location = new System.Drawing.Point(454, 6);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(96, 32);
            this.buttonExecute.TabIndex = 6;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = false;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // checkBoxRecursive
            // 
            this.checkBoxRecursive.AutoSize = true;
            this.checkBoxRecursive.CausesValidation = false;
            this.checkBoxRecursive.ForeColor = System.Drawing.Color.White;
            this.checkBoxRecursive.Location = new System.Drawing.Point(141, 32);
            this.checkBoxRecursive.Name = "checkBoxRecursive";
            this.checkBoxRecursive.Size = new System.Drawing.Size(76, 19);
            this.checkBoxRecursive.TabIndex = 5;
            this.checkBoxRecursive.Text = "Recursive";
            this.checkBoxRecursive.UseVisualStyleBackColor = true;
            this.checkBoxRecursive.CheckedChanged += new System.EventHandler(this.checkBoxRecursive_CheckedChanged);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Enabled = false;
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(333, 6);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(86, 23);
            this.dateTimePickerTo.TabIndex = 4;
            this.dateTimePickerTo.CloseUp += new System.EventHandler(this.dateTimePickerTo_CloseUp);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Enabled = false;
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(191, 6);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(86, 23);
            this.dateTimePickerFrom.TabIndex = 3;
            this.dateTimePickerFrom.Value = new System.DateTime(2022, 9, 9, 11, 50, 59, 0);
            this.dateTimePickerFrom.CloseUp += new System.EventHandler(this.dateTimePickerFrom_CloseUp);
            // 
            // checkBoxTo
            // 
            this.checkBoxTo.AutoSize = true;
            this.checkBoxTo.CausesValidation = false;
            this.checkBoxTo.ForeColor = System.Drawing.Color.White;
            this.checkBoxTo.Location = new System.Drawing.Point(299, 10);
            this.checkBoxTo.Name = "checkBoxTo";
            this.checkBoxTo.Size = new System.Drawing.Size(38, 19);
            this.checkBoxTo.TabIndex = 2;
            this.checkBoxTo.Text = "To";
            this.checkBoxTo.UseVisualStyleBackColor = true;
            this.checkBoxTo.CheckedChanged += new System.EventHandler(this.checkBoxTo_CheckedChanged);
            // 
            // checkBoxFrom
            // 
            this.checkBoxFrom.AutoSize = true;
            this.checkBoxFrom.CausesValidation = false;
            this.checkBoxFrom.ForeColor = System.Drawing.Color.White;
            this.checkBoxFrom.Location = new System.Drawing.Point(141, 9);
            this.checkBoxFrom.Name = "checkBoxFrom";
            this.checkBoxFrom.Size = new System.Drawing.Size(54, 19);
            this.checkBoxFrom.TabIndex = 1;
            this.checkBoxFrom.Text = "From";
            this.checkBoxFrom.UseVisualStyleBackColor = true;
            this.checkBoxFrom.CheckedChanged += new System.EventHandler(this.checkBoxFrom_CheckedChanged);
            // 
            // comboBoxActionType
            // 
            this.comboBoxActionType.CausesValidation = false;
            this.comboBoxActionType.FormattingEnabled = true;
            this.comboBoxActionType.Items.AddRange(new object[] {
            "Copy",
            "Move",
            "Delete"});
            this.comboBoxActionType.Location = new System.Drawing.Point(8, 24);
            this.comboBoxActionType.Name = "comboBoxActionType";
            this.comboBoxActionType.Size = new System.Drawing.Size(120, 23);
            this.comboBoxActionType.TabIndex = 7;
            this.comboBoxActionType.SelectedIndexChanged += new System.EventHandler(this.comboBoxActionType_SelectedIndexChanged);
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.Black;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.CausesValidation = false;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox.Location = new System.Drawing.Point(0, 210);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox.Size = new System.Drawing.Size(990, 354);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.panelHome);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(990, 564);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panelProgress.ResumeLayout(false);
            this.panelProgress.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHome;
        private Label labelDestination;
        private Label labelSource;
        private Button buttonDestination;
        private Button buttonSource;
        private Panel panelProgress;
        private Label labelProgressOf;
        private ProgressBar progressBar;
        private Panel panelControls;
        private DateTimePicker dateTimePickerTo;
        private DateTimePicker dateTimePickerFrom;
        private CheckBox checkBoxTo;
        private CheckBox checkBoxFrom;
        private ComboBox comboBoxActionType;
        private Button buttonExecute;
        private CheckBox checkBoxRecursive;
        private RichTextBox richTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private Label label1;
    }
}
