using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SrcdsManager.SubForms
{
    public partial class Downloading : Form
    {
        public Downloading()
        {
            InitializeComponent();
        }
        public void Value(int value)
        {
            progressBar1.Value = value;
        }
    }
}
