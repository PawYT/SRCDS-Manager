using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SrcdsManager
{
    public partial class ServConfig : Form
    {
        private Manager caller;
        private SrcdsMonitor mon;

        List<CheckBox> cpuList = new List<CheckBox>();

        public ServConfig(object caller, object mon)
        {
            InitializeComponent();
            this.caller = (Manager)caller;
            this.mon = (SrcdsMonitor)mon;

            autoStart.Checked = this.mon.isAutoStart;

            this.Text = this.mon.getName() + " - Configuration";

            addr.Text = this.mon.getAddr();
            parms.Text = this.mon.getCmd();
            executable.Text = this.mon.getExe();
            name.Text = this.mon.getName();
			port.Text = this.mon.getPort();
			maxplayers.Text = this.mon.getMaxplayers(true);

			//There has GOT to be a better way of doing this...
			cpuList.Add(cpu1);
            cpuList.Add(cpu2);
            cpuList.Add(cpu3);
            cpuList.Add(cpu4);
            cpuList.Add(cpu5);
            cpuList.Add(cpu6);
            cpuList.Add(cpu7);
            cpuList.Add(cpu8);
            cpuList.Add(cpu9);
            cpuList.Add(cpu10);
            cpuList.Add(cpu12);
            cpuList.Add(cpu13);
            cpuList.Add(cpu14);
            cpuList.Add(cpu15);
            cpuList.Add(cpu16);

            foreach (CheckBox box in cpuList)
            {
                box.CheckStateChanged += new EventHandler(cpu_CheckedChanged);
            }
            for (int c = 0; c < Environment.ProcessorCount; c++)
            {
                cpuList[c].Visible = true;
            }
            if (this.mon.AffinityMask != new String('1', Environment.ProcessorCount))
            {
                cpuAll.Checked = false;
                for (int c = 0; c < Environment.ProcessorCount; c++)
                {
                    if (this.mon.AffinityMask[c] == '1')
                    {
                        cpuList[c].Checked = true;
                    }
                    else
                    {
                        cpuList[c].Checked = false;
                    }
                }
            }
        }
        private void SaveServer()
        {
            //Doing this up here to keep from building twice
            mon.AffinityMask = BuildAffinityString();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("servers.xml");
            XmlNode root = xmlDoc.DocumentElement;
            XmlNode serv = root.SelectSingleNode(String.Format("descendant::server[@id='{0}']", mon.getId()));
            ((XmlElement)serv).SetAttribute("name", name.Text);
            ((XmlElement)serv).SetAttribute("address", addr.Text);
			((XmlElement)serv).SetAttribute("port", port.Text);
			((XmlElement)serv).SetAttribute("maxplayers", maxplayers.Text);
			serv.SelectSingleNode("descendant::executable").InnerText = executable.Text;
            serv.SelectSingleNode("descendant::params").InnerText = parms.Text;
            serv.SelectSingleNode("descendant::autostart").InnerText = autoStart.Checked.ToString();
            serv.SelectSingleNode("descendant::affinity").InnerText = mon.AffinityMask;
            xmlDoc.Save("servers.xml");

            System.Net.IPAddress ip;
            if (!System.Net.IPAddress.TryParse(addr.Text, out ip))
            {
                MessageBox.Show("The value enetered in the IP field is invalid", "Invalid IP");
                return;
            }
            uint _port;
            if (!uint.TryParse(port.Text, out _port))
            {
                MessageBox.Show("The value enetered in the port field is invalid", "Invalid port");
                return;
            }

            mon.isAutoStart = autoStart.Checked;
            mon.setCmd(parms.Text);
            mon.setExe(executable.Text);
            mon.setName(name.Text);
            mon.setIPAddr(addr.Text);
            mon.setPort(port.Text);
        }

        private void cpu_CheckedChanged(object sender, EventArgs e)
        {
            if (cpuAll.Checked)
            {
                cpuAll.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveServer();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubForms.DeleteForm delete = new SubForms.DeleteForm();
            delete.ShowDialog(this);
            if (delete.DialogResult == DialogResult.OK)
            {
                if (delete.DeleteFiles)
                {
                    String path = new System.IO.FileInfo(mon.getExe()).DirectoryName;
                    try
                    {
                        System.IO.Directory.Delete(path, true);
                    }
                    catch (Exception ex)
                    {
                        if (ex.GetType() != typeof(System.IO.DirectoryNotFoundException))
                        {
                            throw;
                        }
                    }
                }
                caller.DeleteServer(mon);
            }
            delete.Dispose();
            this.Dispose();
        }

        private void cpuAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cpuAll.Checked)
            {
                foreach (CheckBox box in cpuList)
                {
                    box.CheckStateChanged -= new EventHandler(cpu_CheckedChanged);
                }
                foreach (CheckBox box in cpuList)
                {
                    box.Checked = cpuAll.Checked;
                }
                foreach (CheckBox box in cpuList)
                {
                    box.CheckStateChanged += new EventHandler(cpu_CheckedChanged);
                }
            }
        }
        private string BuildAffinityString()
        {
            if (cpuAll.Checked)
            {
                return new String('1', Environment.ProcessorCount);
            }
            else
            {
                StringBuilder mask = new StringBuilder(new String('0', Environment.ProcessorCount));
                for (int c = 0; c < Environment.ProcessorCount; c++)
                {
                    if (cpuList[c].Checked)
                    {
                        mask[c] = '1';
                    }
                }
                return mask.ToString();
            }
        }
    }
}
