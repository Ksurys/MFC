namespace MFC
{
    partial class OFMS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.заграничныйПаспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(929, 788);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1071, 788);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.услугиToolStripMenuItem,
            this.заявкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1196, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заграничныйПаспортToolStripMenuItem});
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // заявкиToolStripMenuItem
            // 
            this.заявкиToolStripMenuItem.Name = "заявкиToolStripMenuItem";
            this.заявкиToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.заявкиToolStripMenuItem.Text = "Заявки";
            this.заявкиToolStripMenuItem.Click += new System.EventHandler(this.заявкиToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.maskedTextBox4);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.maskedTextBox3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.maskedTextBox2);
            this.panel2.Controls.Add(this.maskedTextBox1);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(3, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1170, 735);
            this.panel2.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "старого образца",
            "биометрический",
            "дипломатический",
            "служебный",
            "морской"});
            this.comboBox1.Location = new System.Drawing.Point(242, 476);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(298, 30);
            this.comboBox1.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(52, 476);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 27);
            this.label13.TabIndex = 26;
            this.label13.Text = "Тип оформления";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(384, 662);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(497, 59);
            this.button2.TabIndex = 25;
            this.button2.Text = "Оформить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(52, 586);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 27);
            this.label12.TabIndex = 24;
            this.label12.Text = "Кем выдан";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(197, 586);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(519, 30);
            this.textBox5.TabIndex = 23;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox4.Location = new System.Drawing.Point(282, 528);
            this.maskedTextBox4.Mask = "000-000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(92, 30);
            this.maskedTextBox4.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(51, 528);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 27);
            this.label11.TabIndex = 21;
            this.label11.Text = "Код подразделения";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox3.Location = new System.Drawing.Point(197, 422);
            this.maskedTextBox3.Mask = "00/00/0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(135, 30);
            this.maskedTextBox3.TabIndex = 20;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(52, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 27);
            this.label10.TabIndex = 19;
            this.label10.Text = "Дата выдачи";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(277, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 27);
            this.label9.TabIndex = 17;
            this.label9.Text = "Номер";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(365, 363);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 30);
            this.textBox3.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(51, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "Серия";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(133, 363);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 30);
            this.textBox2.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButton2);
            this.panel4.Controls.Add(this.radioButton1);
            this.panel4.Location = new System.Drawing.Point(128, 124);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 37);
            this.panel4.TabIndex = 13;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(150, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(109, 26);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Женский";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 26);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Мужской";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox2.Location = new System.Drawing.Point(74, 229);
            this.maskedTextBox2.Mask = "8 (999) 000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(187, 30);
            this.maskedTextBox2.TabIndex = 12;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(594, 125);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(135, 30);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(435, 229);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(294, 30);
            this.textBox4.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(282, 74);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(643, 29);
            this.textBox1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(431, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(69, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Контактный телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(421, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(69, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(69, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "ФИО гражданина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Паспортные данные";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Персональные данные";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dataGridView2);
            this.panel5.Location = new System.Drawing.Point(12, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1149, 534);
            this.panel5.TabIndex = 34;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(57, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(994, 311);
            this.dataGridView2.TabIndex = 27;
            // 
            // заграничныйПаспортToolStripMenuItem
            // 
            this.заграничныйПаспортToolStripMenuItem.Name = "заграничныйПаспортToolStripMenuItem";
            this.заграничныйПаспортToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.заграничныйПаспортToolStripMenuItem.Text = "Заграничный паспорт";
            this.заграничныйПаспортToolStripMenuItem.Click += new System.EventHandler(this.заграничныйПаспортToolStripMenuItem_Click);
            // 
            // OFMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1196, 830);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OFMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OFMS";
            this.Load += new System.EventHandler(this.OFMS_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявкиToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem заграничныйПаспортToolStripMenuItem;
    }
}