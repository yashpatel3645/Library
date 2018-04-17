namespace Library
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueNweBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.faToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.outOfSubmissionDateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.registrationToolStripMenuItem,
            this.showDetailsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.issueNweBookToolStripMenuItem,
            this.returnBookToolStripMenuItem1});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(46, 20);
            this.fileMenu.Text = "&Book";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openToolStripMenuItem.Text = "&Update";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // issueNweBookToolStripMenuItem
            // 
            this.issueNweBookToolStripMenuItem.Name = "issueNweBookToolStripMenuItem";
            this.issueNweBookToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.issueNweBookToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.issueNweBookToolStripMenuItem.Text = "&Issue New Book";
            this.issueNweBookToolStripMenuItem.Click += new System.EventHandler(this.issueNweBookToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem1
            // 
            this.returnBookToolStripMenuItem1.Name = "returnBookToolStripMenuItem1";
            this.returnBookToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.returnBookToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.returnBookToolStripMenuItem1.Text = "&Return Book";
            this.returnBookToolStripMenuItem1.Click += new System.EventHandler(this.returnBookToolStripMenuItem1_Click);
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem1,
            this.faToolStripMenuItem});
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.registrationToolStripMenuItem.Text = "&Registration";
            // 
            // studentToolStripMenuItem1
            // 
            this.studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            this.studentToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.studentToolStripMenuItem1.Text = "&Student";
            this.studentToolStripMenuItem1.Click += new System.EventHandler(this.studentToolStripMenuItem1_Click);
            // 
            // faToolStripMenuItem
            // 
            this.faToolStripMenuItem.Name = "faToolStripMenuItem";
            this.faToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.faToolStripMenuItem.Text = "&Faculty";
            this.faToolStripMenuItem.Click += new System.EventHandler(this.faToolStripMenuItem_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentDetailsToolStripMenuItem,
            this.facultyDetailsToolStripMenuItem,
            this.studentDetailsToolStripMenuItem1,
            this.facultyDetailsToolStripMenuItem1,
            this.outOfSubmissionDateToolStripMenuItem1});
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.showDetailsToolStripMenuItem.Text = "&Show Details";
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.studentDetailsToolStripMenuItem.Text = "&Books";
            this.studentDetailsToolStripMenuItem.Click += new System.EventHandler(this.studentDetailsToolStripMenuItem_Click);
            // 
            // facultyDetailsToolStripMenuItem
            // 
            this.facultyDetailsToolStripMenuItem.Name = "facultyDetailsToolStripMenuItem";
            this.facultyDetailsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.facultyDetailsToolStripMenuItem.Text = "&Issued Books";
            this.facultyDetailsToolStripMenuItem.Click += new System.EventHandler(this.facultyDetailsToolStripMenuItem_Click);
            // 
            // studentDetailsToolStripMenuItem1
            // 
            this.studentDetailsToolStripMenuItem1.Name = "studentDetailsToolStripMenuItem1";
            this.studentDetailsToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.studentDetailsToolStripMenuItem1.Text = "&Student Details";
            this.studentDetailsToolStripMenuItem1.Click += new System.EventHandler(this.studentDetailsToolStripMenuItem1_Click);
            // 
            // facultyDetailsToolStripMenuItem1
            // 
            this.facultyDetailsToolStripMenuItem1.Name = "facultyDetailsToolStripMenuItem1";
            this.facultyDetailsToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.facultyDetailsToolStripMenuItem1.Text = "&Faculty Details ";
            this.facultyDetailsToolStripMenuItem1.Click += new System.EventHandler(this.facultyDetailsToolStripMenuItem1_Click);
            // 
            // outOfSubmissionDateToolStripMenuItem1
            // 
            this.outOfSubmissionDateToolStripMenuItem1.Name = "outOfSubmissionDateToolStripMenuItem1";
            this.outOfSubmissionDateToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.outOfSubmissionDateToolStripMenuItem1.Text = "&Out Of Submission Date";
            this.outOfSubmissionDateToolStripMenuItem1.Click += new System.EventHandler(this.outOfSubmissionDateToolStripMenuItem1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 707);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1350, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Library.Properties.Resources.ijo8KeK;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Library Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.close);
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem faToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facultyDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facultyDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem issueNweBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem outOfSubmissionDateToolStripMenuItem1;
    }
}



