using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SrcdsManager
{
    public partial class UnknownApp : Form
    {
        private Manager sender;

        public UnknownApp(object sender)
        {
            InitializeComponent();
            this.sender = (Manager)sender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startinfo = new System.Diagnostics.ProcessStartInfo();
            startinfo.FileName = this.sender.getSteamCmd();
            if (appId.Text == "")
            {
                MessageBox.Show("Please enter an app id", "Invalid App ID", MessageBoxButtons.OK);
                return;
            }
            startinfo.Arguments = String.Format("+login anonymous +force_install_dir {0} +app_update {1} validate +quit",
                new System.IO.FileInfo(this.sender.getSelectedMon().getExe()).Directory.FullName, appId.Text);
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = startinfo;
            try
            {
                proc.Start();
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(System.ComponentModel.Win32Exception))
                {
                    MessageBox.Show("The path to the steamcmd executable was invalid", "SteamCMD not foud");
                    return;
                }
                else
                {
                    throw;
                }
            }
            this.Dispose();
        }
    }
}
