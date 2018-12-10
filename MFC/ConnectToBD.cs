using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace MFC
{
    public partial class ConnectToBD : Form
    {
        private Reg _RI;
        private ControlBD _CBD;

        private bool checking = true;
        private bool get_server_list = true;
        public ConnectToBD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) 
        //Передача данных с формы в метод Register_set библиотеки Reg_info, вызов формы "Авторизация"
        {
            _RI = new Reg();
            _RI.Register_set(comboBox1.Text,comboBox2.Text, textBox2.Text, textBox3.Text);
            Autorizac AU = new Autorizac();
            AU.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _CBD = new ControlBD();
            _CBD.List_Dbs += _CBDList_Dbs;
            Reg.DS = comboBox1.Text;
            Reg.UN = textBox2.Text;
            Reg.UP = textBox3.Text;
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
            };
            Invoke(Act);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Day = DateTime.Today;
            DateTime Time = DateTime.Now;
            toolStripLabel1.Text = "Сегодня: " + Day.ToString("yyyy-MM-dd");
            toolStripLabel2.Text = "Время: " + Time.ToString("hh:mm:ss");
            switch (checking)
            {
                case (true):
                    if (toolStripLabel3.Text.Length > 23)
                    {
                        toolStripLabel3.Text = "Проверка подключения";
                    }
                    else
                    {
                        toolStripLabel3.Text = toolStripLabel3.Text + ".";
                    }
                    break;
            }
            switch (get_server_list)
            {
                case (true):
                    if (toolStripLabel3.Text.Length > 27)
                    {
                        toolStripLabel3.Text = "Получение списка серверов";
                    }
                    else
                    {
                        toolStripLabel3.Text = toolStripLabel3.Text + ".";
                    }
                    break;
            }
        }

        private void ConnectToBD_Load(object sender, EventArgs e)
        {
            _CBD = new ControlBD();
            _CBD.Status += _CBD_Status;
            toolStripLabel3.Text = "Проверка подключения";
            Thread Th1 = new Thread(_CBD.Connection_State);
            Th1.Start();
        }

        public void _CBD_Status(bool value)
        {
            Action Act = () =>
            {
                checking = false;
                switch (value)
                {
                    case (true):
                        get_server_list = false;
                        toolStripLabel3.Text = "Подключение установлено!";
                        Autorizac AU = new Autorizac();
                        AU.Show();
                        this.Hide();
                        break;
                    case (false):
                        toolStripLabel3.Text = "Отсутствует подключение!";
                        _CBD = new ControlBD();
                        _CBD.List_Server += _CBD_List_Server;
                        Thread Th1 = new Thread(_CBD.Get_Server_List);
                        Th1.Start();
                        break;
                }
            };
            Invoke(Act);
        }

        public void _CBD_List_Server(DataTable value)
        {
            Action Act = () =>
            {
                get_server_list = false;
                foreach (DataRow Row in value.Rows)
                {
                    comboBox1.Items.Add(Row[0] + "\\" + Row[1]);
                }
                comboBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                toolStripLabel3.Text = "Список серверов получен.";
            };
            Invoke(Act);
        }
    }
    
}
