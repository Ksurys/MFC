using System;
using System.Windows.Forms;

namespace MFC
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Interface IF = new Interface();
            IF.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Role RP = new Role();
            RP.Show();
            this.Hide();
        }
    }
}
