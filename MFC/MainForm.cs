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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (Program.ADMINACCESS == true)
            {
                button8.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminForm AF = new AdminForm();
            AF.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Abonent_Otdel AO = new Abonent_Otdel();
            AO.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PasportnStol PS = new PasportnStol();
            PS.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OFMS OF = new OFMS();
            OF.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ZAGS ZG = new ZAGS();
            ZG.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SocZashch SZ = new SocZashch();
            SZ.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Universal UN = new Universal();
            UN.Show();
            this.Hide();
        }
    }
}
