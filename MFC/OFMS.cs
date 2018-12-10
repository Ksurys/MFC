using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFC
{
    public partial class OFMS : Form
    {
        public OFMS()
        {
            InitializeComponent();
            if (Program.BACKTOADMIN == true)
            {
                button3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            MF.Show();
            this.Close();
        }

        private void OFMS_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel5.Visible = false;
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Visible = true;
        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel5.Visible = true;
        }

        private void заграничныйПаспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
    }
}
