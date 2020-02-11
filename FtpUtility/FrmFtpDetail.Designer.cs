namespace FtpUtility
{
    partial class FrmFtpDetail
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblTotalFileCount = new System.Windows.Forms.Label();
            this.lblTotalFile = new System.Windows.Forms.Label();
            this.DGVQueuedFiles = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastModifiedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastAccessTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDirectoryPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtURL = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnGetFtpDirectory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVQueuedFiles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblSize);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.LblTotalFileCount);
            this.groupBox2.Controls.Add(this.lblTotalFile);
            this.groupBox2.Controls.Add(this.DGVQueuedFiles);
            this.groupBox2.Location = new System.Drawing.Point(8, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 255);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Queued Files";
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(539, 13);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(14, 15);
            this.lblSize.TabIndex = 14;
            this.lblSize.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(469, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total Size: ";
            // 
            // LblTotalFileCount
            // 
            this.LblTotalFileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotalFileCount.AutoSize = true;
            this.LblTotalFileCount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalFileCount.Location = new System.Drawing.Point(378, 13);
            this.LblTotalFileCount.Name = "LblTotalFileCount";
            this.LblTotalFileCount.Size = new System.Drawing.Size(14, 15);
            this.LblTotalFileCount.TabIndex = 12;
            this.LblTotalFileCount.Text = "0";
            // 
            // lblTotalFile
            // 
            this.lblTotalFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFile.AutoSize = true;
            this.lblTotalFile.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFile.Location = new System.Drawing.Point(308, 13);
            this.lblTotalFile.Name = "lblTotalFile";
            this.lblTotalFile.Size = new System.Drawing.Size(64, 15);
            this.lblTotalFile.TabIndex = 12;
            this.lblTotalFile.Text = "Total Files:";
            // 
            // DGVQueuedFiles
            // 
            this.DGVQueuedFiles.AllowUserToAddRows = false;
            this.DGVQueuedFiles.AllowUserToDeleteRows = false;
            this.DGVQueuedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVQueuedFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Size,
            this.isFolder,
            this.LastModifiedTime,
            this.LastAccessTime,
            this.URL});
            this.DGVQueuedFiles.Location = new System.Drawing.Point(3, 34);
            this.DGVQueuedFiles.Name = "DGVQueuedFiles";
            this.DGVQueuedFiles.ReadOnly = true;
            this.DGVQueuedFiles.Size = new System.Drawing.Size(605, 218);
            this.DGVQueuedFiles.TabIndex = 0;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // isFolder
            // 
            this.isFolder.DataPropertyName = "isFolder";
            this.isFolder.HeaderText = "Directory";
            this.isFolder.Name = "isFolder";
            this.isFolder.ReadOnly = true;
            // 
            // LastModifiedTime
            // 
            this.LastModifiedTime.DataPropertyName = "LastModifiedTime";
            this.LastModifiedTime.HeaderText = "Last Modified Time";
            this.LastModifiedTime.Name = "LastModifiedTime";
            this.LastModifiedTime.ReadOnly = true;
            // 
            // LastAccessTime
            // 
            this.LastAccessTime.DataPropertyName = "LastAccessTime";
            this.LastAccessTime.HeaderText = "Last Access Time";
            this.LastAccessTime.Name = "LastAccessTime";
            this.LastAccessTime.ReadOnly = true;
            // 
            // URL
            // 
            this.URL.DataPropertyName = "URL";
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtDirectoryPath);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtURL);
            this.groupBox1.Controls.Add(this.TxtUserName);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.BtnGetFtpDirectory);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 135);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "&Directory Path";
            // 
            // TxtDirectoryPath
            // 
            this.TxtDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDirectoryPath.Location = new System.Drawing.Point(86, 79);
            this.TxtDirectoryPath.MaxLength = 500;
            this.TxtDirectoryPath.Name = "TxtDirectoryPath";
            this.TxtDirectoryPath.Size = new System.Drawing.Size(514, 20);
            this.TxtDirectoryPath.TabIndex = 10;
            this.TxtDirectoryPath.Text = "/New Penn Financial";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "&Port";
            // 
            // TxtPort
            // 
            this.TxtPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPort.Location = new System.Drawing.Point(526, 27);
            this.TxtPort.MaxLength = 3;
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(74, 20);
            this.TxtPort.TabIndex = 4;
            this.TxtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPort_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "&Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "&User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&SFTP URL";
            // 
            // TxtURL
            // 
            this.TxtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtURL.Location = new System.Drawing.Point(86, 27);
            this.TxtURL.MaxLength = 100;
            this.TxtURL.Name = "TxtURL";
            this.TxtURL.Size = new System.Drawing.Size(394, 20);
            this.TxtURL.TabIndex = 2;
            this.TxtURL.Text = "us2.hostedftp.com";
            this.TxtURL.TextChanged += new System.EventHandler(this.TxtURL_TextChanged);
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(87, 53);
            this.TxtUserName.MaxLength = 80;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(193, 20);
            this.TxtUserName.TabIndex = 6;
            this.TxtUserName.Text = "VLRNPF";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassword.Location = new System.Drawing.Point(407, 53);
            this.TxtPassword.MaxLength = 50;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(193, 20);
            this.TxtPassword.TabIndex = 8;
            this.TxtPassword.Text = "VLRNPF@2018";
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // BtnGetFtpDirectory
            // 
            this.BtnGetFtpDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGetFtpDirectory.Location = new System.Drawing.Point(449, 105);
            this.BtnGetFtpDirectory.Name = "BtnGetFtpDirectory";
            this.BtnGetFtpDirectory.Size = new System.Drawing.Size(151, 23);
            this.BtnGetFtpDirectory.TabIndex = 11;
            this.BtnGetFtpDirectory.Text = "&Get Queued Files List";
            this.BtnGetFtpDirectory.UseVisualStyleBackColor = true;
            this.BtnGetFtpDirectory.Click += new System.EventHandler(this.BtnGetFtpDirectory_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblProgress);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Location = new System.Drawing.Point(-1, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 24);
            this.panel1.TabIndex = 5;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProgress.Location = new System.Drawing.Point(61, 5);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 13);
            this.lblProgress.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus.Location = new System.Drawing.Point(9, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Progress:";
            // 
            // FrmFtpDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(628, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFtpDetail";
            this.Text = "FTP Detail";
            this.Load += new System.EventHandler(this.FrmFtpDetail_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVQueuedFiles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtURL;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnGetFtpDirectory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.DataGridView DGVQueuedFiles;
        private System.Windows.Forms.TextBox TxtDirectoryPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn isFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastModifiedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastAccessTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.Label LblTotalFileCount;
        private System.Windows.Forms.Label lblTotalFile;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label8;
    }
}

