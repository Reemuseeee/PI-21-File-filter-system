namespace File_filter_system
{
    partial class EditProfileForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 35);
            label1.Name = "label1";
            label1.Size = new Size(247, 24);
            label1.TabIndex = 0;
            label1.Text = "Редактирование профиля";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 85);
            label2.Name = "label2";
            label2.Size = new Size(47, 24);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 128);
            label3.Name = "label3";
            label3.Size = new Size(93, 24);
            label3.TabIndex = 2;
            label3.Text = "Фамилия";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(55, 175);
            label4.Name = "label4";
            label4.Size = new Size(65, 24);
            label4.TabIndex = 3;
            label4.Text = "Логин";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(55, 225);
            label5.Name = "label5";
            label5.Size = new Size(149, 24);
            label5.TabIndex = 4;
            label5.Text = "Старый пароль";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(55, 274);
            label6.Name = "label6";
            label6.Size = new Size(141, 24);
            label6.TabIndex = 5;
            label6.Text = "Новый пароль";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(570, 364);
            button1.Name = "button1";
            button1.Size = new Size(172, 34);
            button1.TabIndex = 6;
            button1.Text = "Подтвердить";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(307, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 32);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(307, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 32);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(307, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 32);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(307, 225);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(177, 32);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(307, 271);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(177, 32);
            textBox5.TabIndex = 11;
            // 
            // EditProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkMagenta;
            ClientSize = new Size(756, 416);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditProfileForm";
            Text = "EditProfileForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}