using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace D2_Lovers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("C:\\Diablo II"))
            {
                MessageBox.Show("Diablo II is not install on C:\\Diablo II dir.\r\nExiting");
                Application.Exit();
            }

            cb_d2mr.Checked = 
                cb_d2multires.Checked =
                cb_d2se.Checked = 
                cb_fontfixer.Checked = 
                cb_glide.Checked = 
                cb_median.Checked = 
                cb_plugy.Checked = true;
        }


        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact us to : dkatikaridis@gmail.com \r\nor \r\n johnmenex@gmail.com");
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GitHub link:\r\nwww.github.com/dkati/d2_lovers");
        }
    }
}
