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
            userNameBox = new TextBox();
            userSurnameBox = new TextBox();
            userLoginBox = new TextBox();
            userPasswordBox = new TextBox();
            userRPasswordBox = new TextBox();
            completeReg = new Button();
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
            // userNameBox
            // 
            userNameBox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userNameBox.Location = new Point(229, 90);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(238, 32);
            userNameBox.TabIndex = 1;
            userNameBox.Text = "Имя:";
            userNameBox.Enter += userNameBox_Enter;
            userNameBox.Leave += userNameBox_Leave;
            // 
            // userSurnameBox
            // 
            userSurnameBox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSurnameBox.Location = new Point(229, 139);
            userSurnameBox.Name = "userSurnameBox";
            userSurnameBox.Size = new Size(238, 32);
            userSurnameBox.TabIndex = 2;
            userSurnameBox.Text = "Фамилия:";
            userSurnameBox.Enter += userSurnameBox_Enter;
            userSurnameBox.Leave += userSurnameBox_Leave;
            // 
            // userLoginBox
            // 
            userLoginBox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userLoginBox.Location = new Point(229, 188);
            userLoginBox.Name = "userLoginBox";
            userLoginBox.Size = new Size(238, 32);
            userLoginBox.TabIndex = 3;
            userLoginBox.Text = "Логин:";
            userLoginBox.Enter += userLoginBox_Enter;
            userLoginBox.Leave += userLoginBox_Leave;
            // 
            // userPasswordBox
            // 
            userPasswordBox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userPasswordBox.Location = new Point(229, 238);
            userPasswordBox.Name = "userPasswordBox";
            userPasswordBox.Size = new Size(238, 32);
            userPasswordBox.TabIndex = 4;
            userPasswordBox.Text = "Пароль:";
            userPasswordBox.Enter += userPasswordBox_Enter;
            userPasswordBox.Leave += userPasswordBox_Leave;
            // 
            // userRPasswordBox
            // 
            userRPasswordBox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userRPasswordBox.Location = new Point(229, 287);
            userRPasswordBox.Name = "userRPasswordBox";
            userRPasswordBox.Size = new Size(238, 32);
            userRPasswordBox.TabIndex = 5;
            userRPasswordBox.Text = "Пароль повторно:";
            userRPasswordBox.Enter += userRPassworBox_Enter;
            userRPasswordBox.Leave += userRPassworBox_Leave;
            // 
            // completeReg
            // 
            completeReg.BackColor = Color.White;
            completeReg.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            completeReg.Location = new Point(118, 325);
            completeReg.Name = "completeReg";
            completeReg.Size = new Size(472, 39);
            completeReg.TabIndex = 6;
            completeReg.Text = "Зарегистрироваться и вернуться к авторизации";
            completeReg.UseVisualStyleBackColor = false;
            completeReg.Click += completeReg_Click;
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
            Controls.Add(completeReg);
            Controls.Add(userRPasswordBox);
            Controls.Add(userPasswordBox);
            Controls.Add(userLoginBox);
            Controls.Add(userSurnameBox);
            Controls.Add(userNameBox);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userNameBox;
        private TextBox userSurnameBox;
        private TextBox userLoginBox;
        private TextBox userPasswordBox;
        private TextBox userRPasswordBox;
        private Button completeReg;
        private Label label2;
    }
}