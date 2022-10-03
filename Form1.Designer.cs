namespace FileIT
{
    partial class FileIT
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileIT));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logControl = new LogControl();
            this.compareControl = new CompareControl();
            this.searchControl = new SearchControl();
            this.homeControl = new HomeControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.toolStripMenuItem,
            this.logsToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            resources.ApplyResources(this.homeToolStripMenuItem, "homeToolStripMenuItem");
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.compareToolStripMenuItem});
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            resources.ApplyResources(this.toolStripMenuItem, "toolStripMenuItem");
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            resources.ApplyResources(this.searchToolStripMenuItem, "searchToolStripMenuItem");
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // compareToolStripMenuItem
            // 
            this.compareToolStripMenuItem.Name = "compareToolStripMenuItem";
            resources.ApplyResources(this.compareToolStripMenuItem, "compareToolStripMenuItem");
            this.compareToolStripMenuItem.Click += new System.EventHandler(this.compareToolStripMenuItem_Click);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            resources.ApplyResources(this.logsToolStripMenuItem, "logsToolStripMenuItem");
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.logsToolStripMenuItem_Click);
            // 
            // logControl
            // 
            this.logControl.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.logControl, "logControl");
            this.logControl.Name = "logControl";
            // 
            // compareControl
            // 
            resources.ApplyResources(this.compareControl, "compareControl");
            this.compareControl.Name = "compareControl";
            // 
            // searchControl
            // 
            this.searchControl.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.searchControl, "searchControl");
            this.searchControl.Name = "searchControl";
            // 
            // homeControl
            // 
            this.homeControl.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.homeControl, "homeControl");
            this.homeControl.Name = "homeControl";
            // 
            // FileIT
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CausesValidation = false;
            this.Controls.Add(this.homeControl);
            this.Controls.Add(this.searchControl);
            this.Controls.Add(this.compareControl);
            this.Controls.Add(this.logControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FileIT";
            this.ShowIcon = false;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem;
        private ToolStripMenuItem logsToolStripMenuItem;
        private ToolStripMenuItem compareToolStripMenuItem;
        private LogControl logControl;
        private CompareControl compareControl;
        private SearchControl searchControl;
        private HomeControl homeControl;
        private ToolStripMenuItem searchToolStripMenuItem;
    }
}