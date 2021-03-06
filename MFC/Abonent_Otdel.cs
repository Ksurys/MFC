﻿using System;
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
    public partial class Abonent_Otdel : Form
    {
        public Abonent_Otdel()
        {
            InitializeComponent();
            if (Program.BACKTOADMIN == true)
            {
                button5.Visible = true;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            //UslugiAbon UA = new UslugiAbon();
            //UA.Show();
            //this.Hide();
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //StatAbon SA = new StatAbon();
            //SA.Show();
            //this.Hide();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
        }

        private void Abonent_Otdel_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            MF.Show();
            this.Close();
        }

        private void претензииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Export Ex = new Export();
                Ex.Excel_Generation(textBox18.Text, maskedTextBox2.Text, maskedTextBox10.Text, maskedTextBox1.Text, textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text, Convert.ToDecimal(maskedTextBox3.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void еПДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
}
