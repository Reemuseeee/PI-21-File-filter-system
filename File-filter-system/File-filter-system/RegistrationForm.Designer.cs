namespace File_filter_system
{
    partial class RegistrationForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(260, 34);
            label1.Name = "label1";
            label1.Size = new Size(176, 34);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(229, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 32);
            textBox1.TabIndex = 1;
            textBox1.Text = "Имя:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(229, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 32);
            textBox2.TabIndex = 2;
            textBox2.Text = "Фамилия:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(229, 188);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(238, 32);
            textBox3.TabIndex = 3;
            textBox3.Text = "Логин:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(229, 238);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(238, 32);
            textBox4.TabIndex = 4;
            textBox4.Text = "Пароль:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(229, 287);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(238, 32);
            textBox5.TabIndex = 5;
            textBox5.Text = "Пароль повторно:";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(118, 325);
            button1.Name = "button1";
            button1.Size = new Size(472, 39);
            button1.TabIndex = 6;
            button1.Text = "Зарегистрироваться и вернуться к авторизации";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(218, 367);
            label2.Name = "label2";
            label2.Size = new Size(262, 24);
            label2.TabIndex = 7;
            label2.Text = "Уже есть аккаунт? Войдите";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Label label2;
    }
}