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
    public partial class PasportnStol : Form
    {
        public PasportnStol()
        {
            InitializeComponent();
            if (Program.BACKTOADMIN == true)
            {
                button5.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Visible = true;
            panel9.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Visible = false;
            panel9.Visible = false;

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Visible = true;
            panel9.Visible = true;

        }


        private void PasportnStol_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel9.Visible = false;
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            panel9.Visible = false;
        }

  


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            panel2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            MF.Show();
            this.Close();
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void паспортГражданинаРФToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel9.Visible = false;
        }
    }
}
