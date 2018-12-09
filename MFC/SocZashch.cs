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
    public partial class SocZashch : Form
    {
        public SocZashch()
        {
            InitializeComponent();
            if (Program.BACKTOADMIN == true)
            {
                button2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            MF.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel7.Visible = false;
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
            panel7.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel7.Visible = true;
            panel2.Visible = false;

        }

        private void SocZashch_Load(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }
    }
}
