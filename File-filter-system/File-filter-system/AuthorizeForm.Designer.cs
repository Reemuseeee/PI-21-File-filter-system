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
            userLogin = new TextBox();
            userPassword = new TextBox();
            authorizeButton = new Button();
            goToRegForm = new Label();
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
            // userLogin
            // 
            userLogin.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userLogin.Location = new Point(222, 178);
            userLogin.Name = "userLogin";
            userLogin.Size = new Size(273, 32);
            userLogin.TabIndex = 1;
            userLogin.Text = "Логин :";
            // 
            // userPassword
            // 
            userPassword.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userPassword.Location = new Point(222, 235);
            userPassword.Name = "userPassword";
            userPassword.Size = new Size(273, 32);
            userPassword.TabIndex = 2;
            userPassword.Text = "Пароль :";
            // 
            // authorizeButton
            // 
            authorizeButton.BackColor = Color.White;
            authorizeButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            authorizeButton.Location = new Point(299, 288);
            authorizeButton.Name = "authorizeButton";
            authorizeButton.Size = new Size(111, 35);
            authorizeButton.TabIndex = 3;
            authorizeButton.Text = "Вход";
            authorizeButton.UseVisualStyleBackColor = false;
            authorizeButton.Click += authorizeButton_Click;
            // 
            // goToRegForm
            // 
            goToRegForm.AutoSize = true;
            goToRegForm.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            goToRegForm.Location = new Point(151, 326);
            goToRegForm.Name = "goToRegForm";
            goToRegForm.Size = new Size(410, 24);
            goToRegForm.TabIndex = 4;
            goToRegForm.Text = "Не зарегистрированы? Зарегистрироваться";
            goToRegForm.Click += goToRegForm_Click;
            // 
            // AuthorizeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(800, 450);
            Controls.Add(goToRegForm);
            Controls.Add(authorizeButton);
            Controls.Add(userPassword);
            Controls.Add(userLogin);
            Controls.Add(label1);
            Name = "AuthorizeForm";
            Text = "AuthorizeForm";
            Load += AuthorizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userLogin;
        private TextBox userPassword;
        private Button authorizeButton;
        private Label goToRegForm;
    }
}