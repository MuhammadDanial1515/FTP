using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FtpUtility
{
    public partial class FrmFtpDetail : Form
    {
        public FrmFtpDetail()
        {
            InitializeComponent();
        }

        List<QueuedFilesDetails> QFD = new List<QueuedFilesDetails>();
        List<FtpConfigurationcs> FCG = new List<FtpConfigurationcs>();
        List<string> SubDirectories = new List<string>();
        int Status = 0;

        private void ConnectSFTPWithPort(List<FtpConfigurationcs> FC)
        {
            QFD = new List<QueuedFilesDetails>();
            //string remoteDirectory = "/VLR-INOV";
            foreach (var item in FC)
            {
                using (SftpClient sftp = new SftpClient(item.Ftp_Uri, item.Ftp_Port, item.Ftp_Username, item.Ftp_Password))
                {
                    try
                    {
                        sftp.Connect();

                        var FilePath = item.Ftp_Directory;
                        if (!string.IsNullOrEmpty(item.SubDirectory_name))
                        {
                            FilePath = item.Ftp_Directory + "\\" + item.SubDirectory_name;
                      
                        }

                        var files = sftp.ListDirectory(FilePath);

                        foreach (var file in files)
                        {
                            QueuedFilesDetails fd = new QueuedFilesDetails();
                            if (file.IsDirectory)
                            {
                                fd.isFolder = "Yes";
                            }
                            else
                            {
                                fd.isFolder = "No";
                            }

                            fd.FileName = file.Name;
                            if (file.Length != -1)
                            {
                                fd.Size = file.Length;
                            }
                            fd.LastModifiedTime = file.LastWriteTime;
                            fd.LastAccessTime = file.LastAccessTime;
                            fd.URL = file.FullName;
                            QFD.Add(fd);
                        }

                        Status = 1;
                        if (QFD.Count == 0)
                        {
                            Status = 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        Status = -1;
                        //  MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        sftp.Disconnect();
                    }
                }
            }
        }

        private void ConnectSFTPWithoutPort(List<FtpConfigurationcs> FC)
        {
            //string remoteDirectory = "/VLR-INOV";
            foreach (var item in FC)
            {
                using (SftpClient sftp = new SftpClient(item.Ftp_Uri, item.Ftp_Username, item.Ftp_Password))
                {
                    try
                    {
                        sftp.Connect();

                        var FilePath = item.Ftp_Directory;
                        if (!string.IsNullOrEmpty(item.SubDirectory_name))
                        {
                            FilePath = item.Ftp_Directory + "\\" + item.SubDirectory_name;
                        }

                        var files = sftp.ListDirectory(FilePath);

                        foreach (var file in files)
                        {
                            QueuedFilesDetails fd = new QueuedFilesDetails();
                            if (file.IsDirectory)
                            {
                                fd.isFolder = "Yes";
                                SubDirectories.Add(file.Name);
                                //FtpConfigurationcs ftp = new FtpConfigurationcs();
                                //ftp.Ftp_Directory = file.Name;
                                //ftp.Ftp_Uri = item.Ftp_Uri;
                                //ftp.Ftp_Username = item.Ftp_Username;
                                //ftp.Ftp_Password = item.Ftp_Password;

                                //List<FtpConfigurationcs> FC1 = new List<FtpConfigurationcs>();
                                //FC1.Add(ftp);
                                //ConnectSFTPWithoutPort(FC1);
                            }
                            else
                            {
                                fd.isFolder = "No";
                            }

                            fd.FileName = file.Name;
                            if (file.Length != -1)
                            {
                                fd.Size = file.Length;
                            }
                            fd.LastModifiedTime = file.LastWriteTime;
                            fd.LastAccessTime = file.LastAccessTime;
                            fd.URL = file.FullName;
                            QFD.Add(fd);
                        }

                        Status = 1;
                        if (QFD.Count == 0)
                        {
                            Status = 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        Status = -1;
                        //  MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        sftp.Disconnect();
                    }
                }
            }
        }
        private void BtnGetFtpDirectory_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            msg = "Following fields are required." + System.Environment.NewLine;
            if (string.IsNullOrEmpty(TxtURL.Text))
            {
                msg = msg + "- SFTP URL";
                msg = msg + System.Environment.NewLine;
            }
            if (string.IsNullOrEmpty(TxtDirectoryPath.Text))
            {
                msg = msg + "- SFTP Directory";
                msg = msg + System.Environment.NewLine;
            }

            if (string.IsNullOrEmpty(TxtUserName.Text))
            {
                msg = msg + "- SFTP UserName";
                msg = msg + System.Environment.NewLine;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                msg = msg + "- SFTP Password";
                msg = msg + System.Environment.NewLine;
            }

            if (msg == "Following fields are required." + System.Environment.NewLine)
            {
                BackgroundWorker worker = new BackgroundWorker();
                worker.WorkerReportsProgress = true;
                worker.DoWork += worker_DoWork;
                worker.ProgressChanged += worker_ProgressChanged;
                worker.RunWorkerCompleted += RunWorkerCompleted;
                lblStatus.Show();
                lblProgress.Text = "Please wait... Queued files are getting from FTP.";
                BtnGetFtpDirectory.Enabled = false;
                worker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void FrmFtpDetail_Load(object sender, EventArgs e)
        {
            DGVQueuedFiles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGVQueuedFiles.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;
            lblStatus.Hide();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtPort.Text))
            {
                //FCG = DbHelper.GetFTPConfigurtion(330);
                FtpConfigurationcs ftp = new FtpConfigurationcs();

                ftp.Customer_Id = 330;
                ftp.Ftp_Directory = TxtDirectoryPath.Text;
                ftp.Ftp_Username = TxtUserName.Text;
                ftp.Ftp_Password = TxtPassword.Text;
                ftp.Ftp_Uri = TxtURL.Text;                
                FCG.Add(ftp);
                string parentDIR = TxtDirectoryPath.Text;
                ConnectSFTPWithoutPort(FCG);
                if (SubDirectories.Count > 0)
                {
                    foreach (var item in SubDirectories)
                    {
                        ftp.Ftp_Directory = parentDIR + "\\" + item;
                        ConnectSFTPWithoutPort(FCG);
                    }
                }
            }
            else
            {
                FtpConfigurationcs ftp = new FtpConfigurationcs();
                ftp.Customer_Id = 330;
                ftp.Ftp_Directory = TxtDirectoryPath.Text;
                ftp.Ftp_Username = TxtUserName.Text;
                ftp.Ftp_Password = TxtPassword.Text;
                ftp.Ftp_Uri = TxtURL.Text;
                ftp.Ftp_Port =  Convert.ToInt32(TxtPort.Text);
                FCG.Add(ftp);
                ConnectSFTPWithPort(FCG);
            }
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //pbProcess.Value = e.ProgressPercentage;
        }

        void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Status == 1)
            {
                LblTotalFileCount.Text = QFD.Count.ToString();
                if (Math.Round((Convert.ToDouble(QFD.Sum(x => x.Size)) * 0.000000001), 2) > 0.99)
                {
                    lblSize.Text = Math.Round((Convert.ToDouble(QFD.Sum(x => x.Size)) * 0.000000001), 2).ToString() + " GB";
                    DbHelper.SaveChanges(330, Convert.ToInt64(LblTotalFileCount.Text), lblSize.Text);
                }
                else
                {
                    lblSize.Text = Math.Round((Convert.ToDouble(QFD.Sum(x => x.Size)) * 0.000001), 2).ToString() + " MB";
                    DbHelper.SaveChanges(330, Convert.ToInt64(LblTotalFileCount.Text), lblSize.Text);
                } 

                DGVQueuedFiles.DataSource = QFD;
                lblProgress.Text = "Queued file Fetched successfully.";
            }
            else if (Status == 0 )
            {
                DGVQueuedFiles.DataSource = null;
                lblProgress.Text = "No Data Fetched. There is nothing in SFTP Directory";
            }
            else
            {
                DGVQueuedFiles.DataSource = null;
                lblProgress.Text = "No Data Fetched. Something went wrong. Make sure SFTP URL, UserName, Password, Directory or Port are correct.";
            }

            BtnGetFtpDirectory.Enabled = true;
            QFD = new List<QueuedFilesDetails>();
            FCG = new List<FtpConfigurationcs>();
            SubDirectories = new List<string>();
        }

        private void TxtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
