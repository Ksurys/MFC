using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Crypt;

namespace MFC
{
    public partial class Autorizac : Form
    {
        private ControlBD _CBD; //Создание переменной формы "ControlBD"
        public Autorizac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //Закрытие приложения
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            switch (textBox1.Text == "Логин")// Если текст в TextBox равен слову "Логин"
            {
                case (true):
                    textBox1.Clear(); //Удаление данных из TextBox
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
            try
            {
                Reg_info.Reg.Set_Connection(); //Установка соединения с базой
                Reg_info.Reg.Connection.Open(); //Открытие соединения
                SqlDataAdapter auth = new SqlDataAdapter("SELECT COUNT(*) FROM DBO.sotr WHERE login = '" + textBox1.Text + 
                     "' and password = '" + Crypt_Class.Encrypt(textBox2.Text) + "'", Reg_info.Reg.Connection); 
                //Запрос на вывод количества строк, где поля логин и пароль соответствуют значениям из текстового поля 1 и 2
                Reg_info.Reg.Connection.Close(); //Закрытие соединения
                DataTable dt = new DataTable(); //Создание экзампляра объекта DataTable
                auth.Fill(dt); //Заполнение таблицы данными, полученными из запроса
                if (dt.Rows[0][0].ToString() == "1") //Если в первой ячейке таблицы содержиться 1, то 
                {
                    _CBD = new ControlBD(); //Объявление экземпляра класса ControlBD
                    _CBD.Autorization(textBox1.Text, Crypt_Class.Encrypt(textBox2.Text)); //Вызов метода Autorization, передача в метод значений из текстового поля 1 и 2
                    MessageBox.Show("Добро пожаловать, " + Program.FIOSOTR);
                    switch (Program.SYSACCESS) //Проверка значения из переменной SYSACCESS в классе Program
                    {
                        case 0: //если 0
                            switch (Program.PSACCESS)//Проверка значения из переменной PSACCESS в классе Program
                            {
                                case 1: //если 1
                                    Reg_info.Reg.Connection.Close(); //Закрытие соединения с базой
                                    PasportnStol passtol = new PasportnStol(); //Объявление экземпляра класса PasportnStol
                                    passtol.Show(); //Вызов формы
                                    this.Close(); //Закрытие текущей формы
                                    break;
                            }
                            switch (Program.AOACCESS)
                            {
                                case 1:
                                    Reg_info.Reg.Connection.Close();
                                    Abonent_Otdel ao_otdel = new Abonent_Otdel();
                                    ao_otdel.Show();
                                    this.Close();
                                    break;
                            }
                            switch (Program.UOACCESS)
                            {
                                case 1:
                                    Reg_info.Reg.Connection.Close();
                                    Universal uo_otdel = new Universal();
                                    uo_otdel.Show();
                                    this.Close();
                                    break;
                            }
                            switch (Program.OFMSACCESS)
                            {
                                case 1:
                                    Reg_info.Reg.Connection.Close();
                                    OFMS ofms = new OFMS();
                                    ofms.Show();
                                    this.Close();
                                    break;
                            }
                            switch (Program.ZAGZACCESS)
                            {
                                case 1:
                                    Reg_info.Reg.Connection.Close();
                                    ZAGS zags = new ZAGS();
                                    zags.Show();
                                    this.Close();
                                    break;
                            }
                            switch (Program.SZACCESS)
                            {
                                case 1:
                                    Reg_info.Reg.Connection.Close();
                                    SocZashch sz_otdel = new SocZashch();
                                    sz_otdel.Show();
                                    this.Close();
                                    break;
                            }
                            break;
                        case 1:
                            Reg_info.Reg.Connection.Close();
                            Program.ADMINACCESS = false;
                            Program.BACKTOADMIN = true;
                            MainForm MF = new MainForm();
                            MF.Show();
                            this.Close();
                            break;
                        case 2:
                            Reg_info.Reg.Connection.Close();
                            Program.ADMINACCESS = true;
                            Program.BACKTOADMIN = true;
                            MainForm MainForm = new MainForm();
                            MainForm.Show();
                            this.Close();
                            break;

                    }

                }
                else
                {
                    MessageBox.Show("Указанной связки Логин-Пароль не существует");
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Reg_info.Reg.Connection.Close();

        }
        
        }
    }

