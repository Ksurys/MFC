using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace MFC
{
    public partial class ConnectToBD : Form
    {

        private ControlBD _CBD;
        private int checking;
        public ConnectToBD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) 
        //Передача данных с формы в метод Register_set библиотеки Reg_info, вызов формы "Авторизация"
        {
            Reg_info.Reg.Register_set(textBox1.Text,comboBox2.Text, textBox2.Text, textBox3.Text);
            Autorizac AU = new Autorizac();
            AU.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checking = 1;
            toolStripLabel3.Visible = true;
            toolStripLabel3.Text = "Получение списка баз данных";
            _CBD = new ControlBD();
            _CBD.List_Dbs += _CBDList_Dbs;
            Reg_info.Reg.DataSource = textBox1.Text;
            Reg_info.Reg.UserID = textBox2.Text;
            Reg_info.Reg.UserPassword = textBox3.Text;
            Thread Th = new Thread(_CBD.Get_Base_List);
            Th.Start();
        }

        public void _CBDList_Dbs(DataSet value)
        {
            Action Act = () =>
            {
                comboBox2.DataSource = value.Tables[0];
                comboBox2.DisplayMember = "name";
                comboBox2.Enabled = true;
                button2.Enabled = true;
                checking = checking + 1;
            };
            Invoke(Act);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Day = DateTime.Today;
            DateTime Time = DateTime.Now;
            toolStripLabel1.Text = "Дата: " + Day.ToString("yyyy-MM-dd");
            toolStripLabel2.Text = "Время: " + Time.ToString("hh:mm:ss");
            switch (checking)
            {
                case 1:
                    if (toolStripLabel3.Text.Length > 30)
                    {
                        toolStripLabel3.Text = "Получение списка баз данных";
                    }
                    else
                    {
                        toolStripLabel3.Text = toolStripLabel3 + ".";
                    }
                    break;
                case 2:
                    toolStripLabel3.Text = "Список баз данных получен!";
                    break;
            }

        }

        private void ConnectToBD_Load(object sender, EventArgs e)
        {

        }

    }
    
}
