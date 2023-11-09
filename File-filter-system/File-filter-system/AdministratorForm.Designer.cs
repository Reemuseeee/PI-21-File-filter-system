namespace File_filter_system
{
    partial class AdministratorForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            button4 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tabPage3 = new TabPage();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            comboBox1 = new ComboBox();
            textBox7 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(965, 450);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightCoral;
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(957, 419);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Фильтр файлов";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(386, 248);
            button3.Name = "button3";
            button3.Size = new Size(180, 32);
            button3.TabIndex = 8;
            button3.Text = "Отфильтровать";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(12, 248);
            button2.Name = "button2";
            button2.Size = new Size(251, 32);
            button2.TabIndex = 7;
            button2.Text = "Сгенерировать пример";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(386, 84);
            button1.Name = "button1";
            button1.Size = new Size(114, 32);
            button1.TabIndex = 6;
            button1.Text = "Обзор";
            button1.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(386, 192);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 32);
            numericUpDown1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(323, 32);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 32);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 167);
            label3.Name = "label3";
            label3.Size = new Size(180, 24);
            label3.TabIndex = 2;
            label3.Text = "Размер файла(Кб)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 167);
            label2.Name = "label2";
            label2.Size = new Size(323, 24);
            label2.TabIndex = 1;
            label2.Text = "Слово или фраза для фильтрации";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 61);
            label1.Name = "label1";
            label1.Size = new Size(182, 24);
            label1.TabIndex = 0;
            label1.Text = "Путь к директории";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightCoral;
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(957, 419);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Пользователь";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(194, 201);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(168, 32);
            textBox6.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(194, 163);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(168, 32);
            textBox5.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(194, 125);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(168, 32);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(194, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 32);
            textBox3.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Location = new Point(12, 264);
            button4.Name = "button4";
            button4.Size = new Size(157, 36);
            button4.TabIndex = 5;
            button4.Text = "Редактировать";
            button4.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 200);
            label8.Name = "label8";
            label8.Size = new Size(91, 24);
            label8.TabIndex = 4;
            label8.Text = "Пароль :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 165);
            label7.Name = "label7";
            label7.Size = new Size(78, 24);
            label7.TabIndex = 3;
            label7.Text = "Логин :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 127);
            label6.Name = "label6";
            label6.Size = new Size(106, 24);
            label6.TabIndex = 2;
            label6.Text = "Фамилия :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 90);
            label5.Name = "label5";
            label5.Size = new Size(60, 24);
            label5.TabIndex = 1;
            label5.Text = "Имя :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 49);
            label4.Name = "label4";
            label4.Size = new Size(157, 24);
            label4.TabIndex = 0;
            label4.Text = "Личные данные";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightCoral;
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Controls.Add(textBox7);
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage3.Location = new Point(4, 27);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(957, 419);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Администрирование";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 25);
            label9.Name = "label9";
            label9.Size = new Size(413, 24);
            label9.TabIndex = 0;
            label9.Text = "Список загеристрированных пользователей";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 81);
            label10.Name = "label10";
            label10.Size = new Size(86, 24);
            label10.TabIndex = 1;
            label10.Text = "Столбец";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(373, 81);
            label11.Name = "label11";
            label11.Size = new Size(65, 24);
            label11.TabIndex = 2;
            label11.Text = "Поиск";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(110, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 32);
            comboBox1.TabIndex = 3;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(461, 78);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(198, 32);
            textBox7.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column4, Column5, Column6, Column7 });
            dataGridView1.GridColor = SystemColors.GradientActiveCaption;
            dataGridView1.Location = new Point(9, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(933, 251);
            dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "№";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Логин";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Пароль";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Имя";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Фамилия";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Число предупреждений";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Число редакций профиля";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 450);
            Controls.Add(tabControl1);
            Name = "AdministratorForm";
            Text = "AdministratorForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button3;
        private Button button2;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TabPage tabPage3;
        private ComboBox comboBox1;
        private Label label11;
        private Label label10;
        private Label label9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private TextBox textBox7;
    }
}