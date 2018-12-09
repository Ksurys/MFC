using System;
using System.Windows.Forms;
using Crypt;

namespace MFC
{
    public partial class Role : Form
    {
        ControlBD _CBD = new ControlBD();
        int ao, ps, uo, sz, of, za;
        public Role()
        {
            InitializeComponent();
        }

        private void Grid_Load()
        {
            _CBD.Sotr_Select_void();
            dataGridView1.DataSource = Program.Sotr_Select;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[1].Width = 135;
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[2].Width = 135;
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[3].Width = 135;
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = true;
            dataGridView1.Columns[6].Width = 135;
            dataGridView1.Columns[6].HeaderText = "E-mail";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }
        private void List_Load()
        {
            _CBD.Role_Select_void();
            listBox1.DataSource = Program.Role_Select;
            listBox1.DisplayMember = "Name_Role";
            listBox1.ValueMember = "id_Role";
        }

        private void Role_Load(object sender, EventArgs e)
        {
            Grid_Load();
            List_Load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminForm AF = new AdminForm();
            AF.Show();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ps = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ps = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ao = 0;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ao = 1;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            uo = 0;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            uo = 1;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            za = 0;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            za = 1;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            sz = 0;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            sz = 1;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            of = 0;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            of = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить выбранного пользователя?", "МФЦ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    try
                    {
                        _CBD.Sotr_delete_void(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                        Grid_Load();
                    }
                    catch
                    {
                        Reg_info.Reg.Connection.Close();
                        MessageBox.Show("Error!", "МФЦ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            _CBD.get_role_void(listBox1.Text);
            switch (Program.RG_PSA)
            {
                case 0:
                    radioButton1.Checked = true;
                    break;
                case 1:
                    radioButton2.Checked = true;
                    break;
            }
            switch (Program.RG_AOA)
            {
                case 0:
                    radioButton3.Checked = true;
                    break;
                case 1:
                    radioButton4.Checked = true;
                    break;
            }
            switch (Program.RG_UOA)
            {
                case 0:
                    radioButton6.Checked = true;
                    break;
                case 1:
                    radioButton5.Checked = true;
                    break;
            }
            switch (Program.RG_SZA)
            {
                case 0:
                    radioButton9.Checked = true;
                    break;
                case 1:
                    radioButton10.Checked = true;
                    break;
            }
            switch (Program.RG_ZAGSA)
            {
                case 0:
                    radioButton12.Checked = true;
                    break;
                case 1:
                    radioButton11.Checked = true;
                    break;
            }
            switch (Program.RG_OFMSA)
            {
                case 0:
                    radioButton7.Checked = true;
                    break;  
                case 1:
                    radioButton8.Checked = true;
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                _CBD.Role_add_void(textBox6.Text, ao, ps, uo, of, za, sz);
                List_Load();
            }
            catch
            {
                Reg_info.Reg.Connection.Close();
                MessageBox.Show("Получены не все данные!", "МФЦ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                _CBD.Role_edit_void(Convert.ToInt16(listBox1.SelectedValue.ToString()), textBox6.Text, ao, ps, uo, of, za, sz);
                List_Load();
            }
            catch
            {
                Reg_info.Reg.Connection.Close();
                MessageBox.Show("Получены не все данные!", "МФЦ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить выбранную роль?", "МФЦ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    try
                    {
                        _CBD.Role_delete_void(Convert.ToInt16(listBox1.SelectedValue.ToString()));
                        List_Load();
                    }
                    catch
                    {
                        Reg_info.Reg.Connection.Close();
                        MessageBox.Show("Роль не выбрана!", "АРМ Продажа товара", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox4.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                listBox1.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                switch (Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value.ToString()))
                {
                    case 0:
                        comboBox1.SelectedIndex = 0;
                        break;
                    case 1:
                        comboBox1.SelectedIndex = 1;
                        break;
                    case 2:
                        comboBox1.SelectedIndex = 2;
                        break;
                }
            }
            catch
            {
                Reg_info.Reg.Connection.Close();
                MessageBox.Show("Выберите строку, содержащую данные!", "МФЦ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            MF.Show();
            this.Close();
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
                    if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox4.Text != "") && (textBox5.Text != "") && (textBox7.Text != "") && (textBox8.Text != "") && (comboBox1.SelectedIndex >= 0) && (listBox1.SelectedIndex >= 0))
                    {
                        try
                        {
                            _CBD.Sotr_add_void(textBox1.Text, textBox2.Text, textBox3.Text, Crypt_Class.Encrypt(textBox5.Text), textBox8.Text, textBox7.Text, Convert.ToInt32(listBox1.SelectedValue.ToString()), comboBox1.SelectedIndex);
                            Grid_Load();
                        }
                        catch (Exception ex)
                        {
                            Reg_info.Reg.Connection.Close();
                            MessageBox.Show(ex.Message);
                        }        
                    }
                    else
                    {
                        MessageBox.Show("Не все поля заполнены!", "МФЦ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case (false):
                    textBox4.Clear();
                    textBox5.Clear();
                    MessageBox.Show("Пароли не совпадают!", "МФЦ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            switch (textBox4.Text == textBox5.Text)
            {
                case (true):
                    if ((dataGridView1.CurrentRow.Cells[0].Value != null) && (textBox1.Text != "") && (textBox2.Text != "")  && (textBox4.Text != "") && (textBox5.Text != "") && (textBox7.Text != "") && (textBox8.Text != "") && (comboBox1.SelectedIndex >= 0) && (listBox1.SelectedIndex >= 0))
                    {
                        try
                        {
                            _CBD.Sotr_edit_void(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()), textBox1.Text, textBox2.Text, textBox3.Text, Crypt_Class.Encrypt(textBox5.Text), textBox8.Text, textBox7.Text, Convert.ToInt32(listBox1.SelectedValue.ToString()), comboBox1.SelectedIndex);
                            Grid_Load();
                        }
                        catch (Exception ex)
                        {
                            Reg_info.Reg.Connection.Close();
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Не все поля заполнены!", "МФЦ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case (false):
                    textBox4.Clear();
                    textBox5.Clear();
                    MessageBox.Show("Пароли не совпадают!", "МФЦ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }
    }
}
