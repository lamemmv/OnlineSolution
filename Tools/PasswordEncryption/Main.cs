using PasswordEncryption.Data;
using PasswordEncryption.Entities;
using SimpleInjector;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System;
using PasswordEncryption.Utils;

namespace PasswordEncryption
{
    public partial class Main : Form
    {
        private IDataService _dataService;
        private IEnumerable<UserDTO> _users;

        public Main(Container container)
        {
            InitializeComponent();
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "MM dd yyyy HH:mm:ss";
            _dataService = container.GetInstance<IDataService>();
            InitializeFolders();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeFolders()
        {
            var currentDate = DateTime.Now.ToString("yyyy.MM.dd");
            string backendSource = @"f:\lamemmv\Publish\handbook.backend";
            string handbookSource = @"f:\lamemmv\Publish\handbook.frontend";
            string deviationSource = @"f:\lamemmv\Publish\deviation.frontend";
            string backendTarget = string.Format(@"f:\lamemmv\Publish\{0}\backend", currentDate);
            string handbookTarget = string.Format(@"f:\lamemmv\Publish\{0}\handbook.frontend", currentDate);
            string deviationTarget = string.Format(@"f:\lamemmv\Publish\{0}\deviation.frontend", currentDate);
            txtSrcBackend.Text = backendSource;
            txtSrcHandbook.Text = handbookSource;
            txtSrcDeviation.Text = deviationSource;
            txtTgtBackend.Text = backendTarget;
            txtTgtHandbook.Text = handbookTarget;
            txtTgtDeviation.Text = deviationTarget;

            if (!System.IO.Directory.Exists(backendTarget))
            {
                System.IO.Directory.CreateDirectory(backendTarget);
            }

            if (!System.IO.Directory.Exists(handbookTarget))
            {
                System.IO.Directory.CreateDirectory(handbookTarget);
            }

            if (!System.IO.Directory.Exists(deviationTarget))
            {
                System.IO.Directory.CreateDirectory(deviationTarget);
            }
        }

        private void Log(string message, Color color, bool completedMessage = false)
        {
            if (completedMessage)
            {
                txtLogs.SelectionStart = txtLogs.TextLength;
                txtLogs.SelectionLength = message.Length;
                txtLogs.SelectionColor = Color.Red;
                txtLogs.AppendText("[" + DateTime.Now.ToString("yyyy.MM.dd") + " " + DateTime.Now.ToLongTimeString() + "] ");
            }

            txtLogs.SelectionStart = txtLogs.TextLength;
            txtLogs.SelectionLength = message.Length;
            txtLogs.SelectionColor = color;
            txtLogs.AppendText(message);
        }

        private void btnBrowseDestination_Click(object sender, System.EventArgs e)
        {
            var folderName = string.Empty;
            // Display the openFile dialog.
            DialogResult result = folderBrowserDialog.ShowDialog();

            // OK button was pressed.
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog.SelectedPath;
                txtTgtBackend.Text = folderName;
            }
            // Cancel button was pressed.
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void EmptyFolder(DirectoryInfo directoryInfo)
        {
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                file.Delete();
            }

            foreach (DirectoryInfo subfolder in directoryInfo.GetDirectories())
            {
                EmptyFolder(subfolder);
            }
        }

        private void btnCopy_Click(object sender, System.EventArgs e)
        {
            DoBackend();
            DoHandbook();
            DoDeviation();
        }

        private void DoBackend()
        {
            Log("===================================\n", Color.Blue, true);
            Log("COPYING BACKEND......\n", Color.Blue, true);
            Log("===================================\n", Color.Blue, true);
            DoCopy(txtSrcBackend.Text, txtTgtBackend.Text);
        }

        private void DoHandbook()
        {
            Log("===================================\n", Color.Blue, true);
            Log("COPYING HANDBOOK FRONTEND......\n", Color.Blue, true);
            Log("===================================\n", Color.Blue, true);
            DoCopy(txtSrcHandbook.Text, txtTgtHandbook.Text);
        }

        private void DoDeviation()
        {
            Log("===================================\n", Color.Blue, true);
            Log("COPYING DEVIATION FRONTEND......\n", Color.Blue, true);
            Log("===================================\n", Color.Blue, true);
            DoCopy(txtSrcDeviation.Text, txtTgtDeviation.Text);
        }

        private void DoCopy(string sourceDir, string destinationDir)
        {
            if (chkEmptyTargetFolder.Checked)
            {
                EmptyFolder(new DirectoryInfo(destinationDir));
            }

            string[] files = Directory.GetFiles(sourceDir, "*.*", SearchOption.AllDirectories);
            var excludeExtensions = GetExcludeExtensions();
            for (int i = 0; i < files.Length; i++)
            {
                var modifiedDate = File.GetLastWriteTime(files[i]);
                if (modifiedDate < dtpDate.Value)
                {
                    continue;
                }

                if (ExcludedFile(files[i], excludeExtensions))
                {
                    continue;
                }

                // Remove path from the file name.
                string fileName = files[i].Substring(sourceDir.Length + 1);

                // Use the Path.Combine method to safely append the file name to the path.
                // Will overwrite if the destination file already exists.
                var src = Path.Combine(sourceDir, fileName);
                var dest = Path.Combine(destinationDir, fileName);
                var targetDir = Path.GetDirectoryName(dest);
                // To copy a folder's contents to a new location:
                // Create a new target folder, if necessary.
                if (!System.IO.Directory.Exists(targetDir))
                {
                    System.IO.Directory.CreateDirectory(targetDir);
                }

                File.Copy(src, dest, true);
                Log("Copied ", Color.Blue, true);
                Log(src, Color.Green);
                Log(" to ", Color.Blue);
                Log(dest + "\n", Color.Green);
            }
        }

        private bool ExcludedFile(string fileName, List<string> extensions)
        {
            for (int i = 0; i < extensions.Count; i++)
            {
                if (fileName.IndexOf(extensions[i]) >= 0)
                {
                    return true;
                }
            }
            return false;
        }

        private List<string> GetExcludeExtensions()
        {
            var extensions = new List<string>();
            if (!chkDll.Checked)
            {
                extensions.Add(".dll");
            }

            if (!chkJs.Checked)
            {
                extensions.Add(".js");
            }
            if (!chkHtml.Checked)
            {
                extensions.Add(".html");
            }
            if (!chkCss.Checked)
            {
                extensions.Add(".css");
            }
            if (!chkCshtml.Checked)
            {
                extensions.Add(".cshtml");
            }
            if (!chkJson.Checked)
            {
                extensions.Add(".json");
            }
            if (!chkTs.Checked)
            {
                extensions.Add(".ts");
            }
            if (!chkPng.Checked)
            {
                extensions.Add(".png");
            }
            if (!chkGif.Checked)
            {
                extensions.Add(".gif");
            }
            if (!chkJpg.Checked)
            {
                extensions.Add(".jpg");
            }
            if (!chkSvg.Checked)
            {
                extensions.Add(".svg");
            }
            if (!chkSvg.Checked)
            {
                extensions.Add(".woff");
            }
            if (!chkTtf.Checked)
            {
                extensions.Add(".ttf");
            }
            if (!chkWoff2.Checked)
            {
                extensions.Add(".woff2");
            }
            if (!chkEot.Checked)
            {
                extensions.Add(".eot");
            }
            if (!chkRdlc.Checked)
            {
                extensions.Add(".rdlc");
            }
            if (!chkConfig.Checked)
            {
                extensions.Add(".config");
            }
            return extensions;
        }

        private void btnBrowSrcBackend_Click(object sender, EventArgs e)
        {
            OpenFolderDialog(txtSrcBackend);
        }

        private void btnBrwSrcHandbook_Click(object sender, EventArgs e)
        {
            OpenFolderDialog(txtSrcHandbook);
        }

        private void btnBrowTgtBackend_Click(object sender, EventArgs e)
        {
            OpenFolderDialog(txtTgtBackend);
        }

        private void btnBrowSrcDeviation_Click(object sender, EventArgs e)
        {
            OpenFolderDialog(txtSrcDeviation);
        }

        private void btnBrowTgtHandbook_Click(object sender, EventArgs e)
        {
            OpenFolderDialog(txtTgtHandbook);
        }

        private void btnBrowTgtDeviation_Click(object sender, EventArgs e)
        {
            OpenFolderDialog(txtTgtDeviation);
        }

        private void OpenFolderDialog(TextBox ctrl)
        {
            var folderName = string.Empty;
            // Display the openFile dialog.
            DialogResult result = folderBrowserDialog.ShowDialog();

            // OK button was pressed.
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog.SelectedPath;
                ctrl.Text = folderName;
            }
            // Cancel button was pressed.
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void btnConnectFtp_Click(object sender, EventArgs e)
        {
            var ftpClient = new FTPUtility(txtUrlFtp.Text, txtUsername.Text, txtPassword.Text);
            ftpClient.DirectoryListDetailed("");
        }
    }
}
