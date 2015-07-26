using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO.Compression;

namespace SrcdsManager.SubForms
{
    public partial class SteamCmd : Form
    {
        private Manager caller;
        private SubForms.Downloading progressBar;

        public SteamCmd(object caller)
        {
            InitializeComponent();
            this.caller = (Manager)caller;

            path.Text = new System.IO.FileInfo(this.caller.steamCmd).DirectoryName.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (download.Checked)
            {
                if (!System.IO.Directory.Exists(path.Text))
                {
                    System.IO.Directory.CreateDirectory(path.Text);
                }
                progressBar = new SubForms.Downloading();
                System.Net.WebClient client = new System.Net.WebClient();
                client.DownloadFileAsync(new Uri("http://media.steampowered.com/client/steamcmd_win32.zip"), path.Text + @"\steamcmd.zip");
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(downloadFinished);
                client.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(downloadProgress);
                progressBar.Show();
            }
            else
            {
                caller.steamCmd = path.Text + @"\steamcmd.exe";

                RegistryKey rkSrcdsManager = Registry.CurrentUser.OpenSubKey("Software\\SrcdsManager", true);
                rkSrcdsManager.SetValue("steamcmd", caller.steamCmd);

                this.Dispose();
            }
        }
        private void downloadFinished(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(path.Text + @"\steamcmd.exe"))
            {
                System.IO.File.Delete(path.Text + @"\steamcmd.exe");
            }
            ZipFile.ExtractToDirectory(path.Text + @"\steamcmd.zip", path.Text);
            System.IO.File.Delete(path.Text + @"\steamcmd.zip");

            caller.steamCmd = path.Text + @"\steamcmd.exe";

            RegistryKey rkSrcdsManager = Registry.CurrentUser.OpenSubKey("Software\\SrcdsManager", true);
            rkSrcdsManager.SetValue("steamcmd", caller.steamCmd);

            progressBar.Dispose();
            this.Dispose();
        }
        private void downloadProgress(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            progressBar.Value(e.ProgressPercentage);
        }
    }
}
