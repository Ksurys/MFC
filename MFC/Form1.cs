using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MFC
{
    public partial class Form1 : Form
    { 
        //SqlConnection DBcon = new SqlConnection(@"Data Source = PRINCESS; Initial Catalog = MFC; Persist Security Info = true; User Id = SA; password = oksana21");
    public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            switch (textBox1.Text == "Логин")
            {
                case (true):
                    textBox1.Clear();
                    break;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            switch (textBox2.Text == "Пароль")
            {
                case (true):
                    textBox2.Clear();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Hide();
                MainForm MF = new MainForm();
                MF.Show();
        }
        
        }
    }

