using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunBar_skeleton
{
    public partial class runbar : Form
    {
        public runbar()
        {
            InitializeComponent();
        }

        private void cmd_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"cmd.exe");
        }

        private void taskmgr_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"taskmgr.exe");
        }

        private void diskpart_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"diskpart.exe");
        }

        private void notepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"notepad.exe");
        }
    }
}
