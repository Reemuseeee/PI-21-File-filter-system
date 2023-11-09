namespace File_filter_system
{
    partial class UserForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            label32 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            wordToFilter = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            label12 = new Label();
            label13 = new Label();
            profileEditCount = new Label();
            warningsCount = new Label();
            userPasswordBox = new TextBox();
            userLoginBox = new TextBox();
            userSurnameBox = new TextBox();
            userNameBox = new TextBox();
            button4 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(991, 481);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightCoral;
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label32);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(wordToFilter);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(983, 450);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Фильтр файлов";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(738, 22);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(542, 22);
            label32.Name = "label32";
            label32.Size = new Size(190, 24);
            label32.TabIndex = 9;
            label32.Text = "Добро пожаловать,";
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
            label3.Location = new Point(386, 164);
            label3.Name = "label3";
            label3.Size = new Size(180, 24);
            label3.TabIndex = 2;
            label3.Text = "Размер файла(Кб)";
            // 
            // wordToFilter
            // 
            wordToFilter.AutoSize = true;
            wordToFilter.Location = new Point(12, 164);
            wordToFilter.Name = "wordToFilter";
            wordToFilter.Size = new Size(323, 24);
            wordToFilter.TabIndex = 1;
            wordToFilter.Text = "Слово или фраза для фильтрации";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 58);
            label1.Name = "label1";
            label1.Size = new Size(182, 24);
            label1.TabIndex = 0;
            label1.Text = "Путь к директории";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightCoral;
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(profileEditCount);
            tabPage2.Controls.Add(warningsCount);
            tabPage2.Controls.Add(userPasswordBox);
            tabPage2.Controls.Add(userLoginBox);
            tabPage2.Controls.Add(userSurnameBox);
            tabPage2.Controls.Add(userNameBox);
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
            tabPage2.Size = new Size(983, 450);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Пользователь";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(709, 21);
            label12.Name = "label12";
            label12.Size = new Size(75, 24);
            label12.TabIndex = 13;
            label12.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(513, 21);
            label13.Name = "label13";
            label13.Size = new Size(190, 24);
            label13.TabIndex = 12;
            label13.Text = "Добро пожаловать,";
            // 
            // profileEditCount
            // 
            profileEditCount.AutoSize = true;
            profileEditCount.Location = new Point(513, 166);
            profileEditCount.Name = "profileEditCount";
            profileEditCount.Size = new Size(252, 24);
            profileEditCount.TabIndex = 11;
            profileEditCount.Text = "Число редакций профиля:";
            // 
            // warningsCount
            // 
            warningsCount.AutoSize = true;
            warningsCount.Location = new Point(513, 93);
            warningsCount.Name = "warningsCount";
            warningsCount.Size = new Size(235, 24);
            warningsCount.TabIndex = 10;
            warningsCount.Text = "Число предупреждений:";
            // 
            // userPasswordBox
            // 
            userPasswordBox.Location = new Point(194, 201);
            userPasswordBox.Name = "userPasswordBox";
            userPasswordBox.Size = new Size(168, 32);
            userPasswordBox.TabIndex = 9;
            // 
            // userLoginBox
            // 
            userLoginBox.Location = new Point(194, 163);
            userLoginBox.Name = "userLoginBox";
            userLoginBox.Size = new Size(168, 32);
            userLoginBox.TabIndex = 8;
            // 
            // userSurnameBox
            // 
            userSurnameBox.Location = new Point(194, 125);
            userSurnameBox.Name = "userSurnameBox";
            userSurnameBox.Size = new Size(168, 32);
            userSurnameBox.TabIndex = 7;
            // 
            // userNameBox
            // 
            userNameBox.Location = new Point(194, 87);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(168, 32);
            userNameBox.TabIndex = 6;
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
            label8.Location = new Point(18, 203);
            label8.Name = "label8";
            label8.Size = new Size(91, 24);
            label8.TabIndex = 4;
            label8.Text = "Пароль :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 168);
            label7.Name = "label7";
            label7.Size = new Size(78, 24);
            label7.TabIndex = 3;
            label7.Text = "Логин :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 130);
            label6.Name = "label6";
            label6.Size = new Size(106, 24);
            label6.TabIndex = 2;
            label6.Text = "Фамилия :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 93);
            label5.Name = "label5";
            label5.Size = new Size(60, 24);
            label5.TabIndex = 1;
            label5.Text = "Имя :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 52);
            label4.Name = "label4";
            label4.Size = new Size(157, 24);
            label4.TabIndex = 0;
            label4.Text = "Личные данные";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 481);
            Controls.Add(tabControl1);
            Name = "UserForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label32;
        private Button button3;
        private Button button2;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label wordToFilter;
        private Label label1;
        private TabPage tabPage2;
        private Label label12;
        private Label label13;
        private Label profileEditCount;
        private Label warningsCount;
        private TextBox userPasswordBox;
        private TextBox userLoginBox;
        private TextBox userSurnameBox;
        private TextBox userNameBox;
        private Button button4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}