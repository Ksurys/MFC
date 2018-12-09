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
    public partial class Universal : Form
    {
        public Universal()
        {
            InitializeComponent();
            if (Program.BACKTOADMIN == true)
            {
                button4.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel2.Visible = false;

        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel4.Visible = false;
            panel3.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
        }

        private void Universal_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel4.Visible = false;
            panel3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            MF.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Export Ex = new Export();
            //Ex.Excel_Generation(dataGridView2);
        }
    }
}
