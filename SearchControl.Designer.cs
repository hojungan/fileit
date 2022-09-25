namespace FileIT
{
    partial class SearchControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFolderPaths = new System.Windows.Forms.Panel();
            this.labelSource = new System.Windows.Forms.Label();
            this.buttonSource = new System.Windows.Forms.Button();
            this.panelSearchOptions = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.comboBoxFileType = new System.Windows.Forms.ComboBox();
            this.labelFileType = new System.Windows.Forms.Label();
            this.searchBgw = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewFileList = new System.Windows.Forms.DataGridView();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenFolder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelFolderPaths.SuspendLayout();
            this.panelSearchOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFolderPaths
            // 
            this.panelFolderPaths.Controls.Add(this.labelSource);
            this.panelFolderPaths.Controls.Add(this.buttonSource);
            this.panelFolderPaths.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFolderPaths.Location = new System.Drawing.Point(0, 0);
            this.panelFolderPaths.Name = "panelFolderPaths";
            this.panelFolderPaths.Size = new System.Drawing.Size(990, 60);
            this.panelFolderPaths.TabIndex = 0;
            // 
            // labelSource
            // 
            this.labelSource.BackColor = System.Drawing.Color.White;
            this.labelSource.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSource.Location = new System.Drawing.Point(149, 8);
            this.labelSource.Name = "labelSource";
            this.labelSource.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelSource.Size = new System.Drawing.Size(832, 32);
            this.labelSource.TabIndex = 6;
            // 
            // buttonSource
            // 
            this.buttonSource.AutoSize = true;
            this.buttonSource.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSource.FlatAppearance.BorderSize = 0;
            this.buttonSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSource.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSource.ForeColor = System.Drawing.Color.White;
            this.buttonSource.Location = new System.Drawing.Point(9, 8);
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.Size = new System.Drawing.Size(136, 32);
            this.buttonSource.TabIndex = 4;
            this.buttonSource.Text = "Source";
            this.buttonSource.UseVisualStyleBackColor = false;
            this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);
            // 
            // panelSearchOptions
            // 
            this.panelSearchOptions.Controls.Add(this.buttonSearch);
            this.panelSearchOptions.Controls.Add(this.textBoxFileName);
            this.panelSearchOptions.Controls.Add(this.labelFileName);
            this.panelSearchOptions.Controls.Add(this.comboBoxFileType);
            this.panelSearchOptions.Controls.Add(this.labelFileType);
            this.panelSearchOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchOptions.Location = new System.Drawing.Point(0, 60);
            this.panelSearchOptions.Name = "panelSearchOptions";
            this.panelSearchOptions.Size = new System.Drawing.Size(990, 68);
            this.panelSearchOptions.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(394, 22);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(82, 29);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(163, 28);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(208, 23);
            this.textBoxFileName.TabIndex = 8;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFileName.ForeColor = System.Drawing.Color.White;
            this.labelFileName.Location = new System.Drawing.Point(163, 10);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(76, 19);
            this.labelFileName.TabIndex = 7;
            this.labelFileName.Text = "File Name";
            // 
            // comboBoxFileType
            // 
            this.comboBoxFileType.FormattingEnabled = true;
            this.comboBoxFileType.Items.AddRange(new object[] {
            "All",
            "Word",
            "PDF",
            "Image",
            "Text"});
            this.comboBoxFileType.Location = new System.Drawing.Point(9, 28);
            this.comboBoxFileType.Name = "comboBoxFileType";
            this.comboBoxFileType.Size = new System.Drawing.Size(121, 23);
            this.comboBoxFileType.TabIndex = 6;
            this.comboBoxFileType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFileType_SelectedIndexChanged);
            // 
            // labelFileType
            // 
            this.labelFileType.AutoSize = true;
            this.labelFileType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFileType.ForeColor = System.Drawing.Color.White;
            this.labelFileType.Location = new System.Drawing.Point(9, 6);
            this.labelFileType.Name = "labelFileType";
            this.labelFileType.Size = new System.Drawing.Size(68, 19);
            this.labelFileType.TabIndex = 5;
            this.labelFileType.Text = "File Type";
            // 
            // searchBgw
            // 
            this.searchBgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.searchBgw_DoWork);
            // 
            // dataGridViewFileList
            // 
            this.dataGridViewFileList.AllowUserToAddRows = false;
            this.dataGridViewFileList.AllowUserToDeleteRows = false;
            this.dataGridViewFileList.AllowUserToResizeColumns = false;
            this.dataGridViewFileList.AllowUserToResizeRows = false;
            this.dataGridViewFileList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFileList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridViewFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilePath,
            this.OpenFolder});
            this.dataGridViewFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFileList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFileList.Location = new System.Drawing.Point(0, 128);
            this.dataGridViewFileList.MultiSelect = false;
            this.dataGridViewFileList.Name = "dataGridViewFileList";
            this.dataGridViewFileList.ReadOnly = true;
            this.dataGridViewFileList.RowTemplate.Height = 25;
            this.dataGridViewFileList.Size = new System.Drawing.Size(990, 436);
            this.dataGridViewFileList.TabIndex = 10;
            this.dataGridViewFileList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFileList_CellClick);
            // 
            // FilePath
            // 
            this.FilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FilePath.FillWeight = 98.47715F;
            this.FilePath.HeaderText = "File Path";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OpenFolder
            // 
            this.OpenFolder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OpenFolder.DataPropertyName = "OpenFolder";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.OpenFolder.DefaultCellStyle = dataGridViewCellStyle1;
            this.OpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFolder.HeaderText = "View";
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.ReadOnly = true;
            this.OpenFolder.Text = "Open In Folder";
            this.OpenFolder.UseColumnTextForButtonValue = true;
            this.OpenFolder.Width = 38;
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.dataGridViewFileList);
            this.Controls.Add(this.panelSearchOptions);
            this.Controls.Add(this.panelFolderPaths);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(990, 564);
            this.panelFolderPaths.ResumeLayout(false);
            this.panelFolderPaths.PerformLayout();
            this.panelSearchOptions.ResumeLayout(false);
            this.panelSearchOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelFolderPaths;
        private Label labelSource;
        private Button buttonSource;
        private Panel panelSearchOptions;
        private Label labelFileType;
        private System.ComponentModel.BackgroundWorker searchBgw;
        private ComboBox comboBoxFileType;
        private Button buttonSearch;
        private TextBox textBoxFileName;
        private Label labelFileName;
        private DataGridView dataGridViewFileList;
        private DataGridViewTextBoxColumn FilePath;
        private DataGridViewButtonColumn OpenFolder;
    }
}
