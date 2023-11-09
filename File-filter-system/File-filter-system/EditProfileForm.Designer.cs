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
            editButton = new Button();
            editNameBox = new TextBox();
            editSurnameBox = new TextBox();
            editLoginBox = new TextBox();
            userPasswordBox = new TextBox();
            userRPasswordBox = new TextBox();
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
            // editButton
            // 
            editButton.BackColor = Color.White;
            editButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            editButton.ForeColor = Color.Black;
            editButton.Location = new Point(570, 364);
            editButton.Name = "editButton";
            editButton.Size = new Size(172, 34);
            editButton.TabIndex = 6;
            editButton.Text = "Подтвердить";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // editNameBox
            // 
            editNameBox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            editNameBox.Location = new Point(307, 82);
            editNameBox.Name = "editNameBox";
            editNameBox.Size = new Size(177, 32);
            editNameBox.TabIndex = 7;
            // 
            // editSurnameBox
            // 
            editSurnameBox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            editSurnameBox.Location = new Point(307, 128);
            editSurnameBox.Name = "editSurnameBox";
            editSurnameBox.Size = new Size(177, 32);
            editSurnameBox.TabIndex = 8;
            // 
            // editLoginBox
            // 
            editLoginBox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            editLoginBox.Location = new Point(307, 175);
            editLoginBox.Name = "editLoginBox";
            editLoginBox.Size = new Size(177, 32);
            editLoginBox.TabIndex = 9;
            // 
            // userPasswordBox
            // 
            userPasswordBox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userPasswordBox.Location = new Point(307, 225);
            userPasswordBox.Name = "userPasswordBox";
            userPasswordBox.Size = new Size(177, 32);
            userPasswordBox.TabIndex = 10;
            // 
            // userRPasswordBox
            // 
            userRPasswordBox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userRPasswordBox.Location = new Point(307, 271);
            userRPasswordBox.Name = "userRPasswordBox";
            userRPasswordBox.Size = new Size(177, 32);
            userRPasswordBox.TabIndex = 11;
            // 
            // EditProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkMagenta;
            ClientSize = new Size(756, 416);
            Controls.Add(userRPasswordBox);
            Controls.Add(userPasswordBox);
            Controls.Add(editLoginBox);
            Controls.Add(editSurnameBox);
            Controls.Add(editNameBox);
            Controls.Add(editButton);
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
        private Button editButton;
        private TextBox editNameBox;
        private TextBox editSurnameBox;
        private TextBox editLoginBox;
        private TextBox userPasswordBox;
        private TextBox userRPasswordBox;
    }
}