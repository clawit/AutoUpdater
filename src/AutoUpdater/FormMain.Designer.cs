namespace AutoUpdater
{
    partial class FormMain
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

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.pgsBar = new System.Windows.Forms.ProgressBar();
            this.lnkDetail = new System.Windows.Forms.LinkLabel();
            this.lstFiles = new System.Windows.Forms.ListView();
            this.colFile = new System.Windows.Forms.ColumnHeader();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Updating...";
            // 
            // pgsBar
            // 
            this.pgsBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgsBar.Location = new System.Drawing.Point(12, 29);
            this.pgsBar.Name = "pgsBar";
            this.pgsBar.Size = new System.Drawing.Size(360, 23);
            this.pgsBar.TabIndex = 1;
            // 
            // lnkDetail
            // 
            this.lnkDetail.AutoSize = true;
            this.lnkDetail.Location = new System.Drawing.Point(12, 55);
            this.lnkDetail.Name = "lnkDetail";
            this.lnkDetail.Size = new System.Drawing.Size(50, 17);
            this.lnkDetail.TabIndex = 2;
            this.lnkDetail.TabStop = true;
            this.lnkDetail.Text = "Detail...";
            this.lnkDetail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDetail_LinkClicked);
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFiles.CheckBoxes = true;
            this.lstFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFile});
            this.lstFiles.FullRowSelect = true;
            this.lstFiles.GridLines = true;
            this.lstFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstFiles.Location = new System.Drawing.Point(12, 75);
            this.lstFiles.MultiSelect = false;
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(360, 174);
            this.lstFiles.TabIndex = 3;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.List;
            // 
            // colFile
            // 
            this.colFile.Text = "File";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(384, 74);
            this.ControlBox = false;
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.lnkDetail);
            this.Controls.Add(this.pgsBar);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoUpdater";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblTitle;
        private ProgressBar pgsBar;
        private LinkLabel lnkDetail;

        #endregion

        private ListView lstFiles;
        private ColumnHeader colFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}