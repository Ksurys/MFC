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
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }

        private void Role_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminForm AF = new AdminForm();
            AF.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            MF.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            switch (textBox4.Text == textBox5.Text)
            {
                case (true):
                    //_BU.Personal_new_void(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text, Convert.ToInt32(listBox1.SelectedValue.ToString()));
                    //Grid_Load();
                    break;
                case (false):
                    textBox4.Clear();
                    textBox5.Clear();
                    MessageBox.Show("Пароли не совпадают!", "АРМ Продажа товара", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }
    }
}
