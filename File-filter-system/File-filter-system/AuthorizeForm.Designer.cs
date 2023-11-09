namespace File_filter_system
{
    partial class AuthorizeForm
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
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(263, 119);
            label1.Name = "label1";
            label1.Size = new Size(181, 34);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(222, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 32);
            textBox1.TabIndex = 1;
            textBox1.Text = "Логин :";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(222, 235);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(273, 32);
            textBox2.TabIndex = 2;
            textBox2.Text = "Пароль :";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(299, 288);
            button1.Name = "button1";
            button1.Size = new Size(111, 35);
            button1.TabIndex = 3;
            button1.Text = "Вход";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(151, 326);
            label2.Name = "label2";
            label2.Size = new Size(410, 24);
            label2.TabIndex = 4;
            label2.Text = "Не зарегистрированы? Зарегистрироваться";
            // 
            // AuthorizeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AuthorizeForm";
            Text = "AuthorizeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label2;
    }
}