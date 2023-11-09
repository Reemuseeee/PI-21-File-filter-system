using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_filter_system
{
    public partial class AuthorizeForm : Form
    {
        public AuthorizeForm()
        {
            InitializeComponent();
        }

        private void goToRegForm_Click(object sender, EventArgs e)
        {
            RegistrationForm reg = new RegistrationForm();
            Hide();
            reg.ShowDialog();
            Show();
        }

        private void AuthorizeForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("Users\\LastUserInfo.txt"))
            {
                using (StreamReader sr = new StreamReader("Users\\LastUserInfo.txt"))
                {
                    userLoginBox_Enter(null, null);
                    userLogin.Text = sr.ReadLine();
                    userLoginBox_Leave(null, null);
                    userPasswordBox_Enter(null, null);
                    userPassword.Text = sr.ReadLine();
                    userPasswordBox_Leave(null, null);

                }
            }
        }

        private void authorizeButton_Click(object sender, EventArgs e)
        {
            if (userLogin.ForeColor == Color.Gray && userPassword.ForeColor == Color.Gray)
            {
                Hide();
                new AdministratorForm("admin").ShowDialog();
                Show();
                using (StreamWriter sw = new StreamWriter("Users\\LastUserInfo.txt"))
                {
                    sw.WriteLine("");
                    sw.WriteLine("");
                }
                return;
            }

            string login = TryLogin();
            if (login == "")
            {
                MessageBox.Show("Пользователь с такими данными не найден, создайте учётную запись.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (login == "False")
            {
                Hide();
                new UserForm(userLogin.Text).ShowDialog();
            }
            else
            {
                Hide();
                new AdministratorForm(userLogin.Text).ShowDialog();
            }

            using (StreamWriter sw = new StreamWriter("Users\\LastUserInfo.txt"))
            {
                sw.WriteLine(userLogin.Text);
                sw.WriteLine(userPassword.Text);
            }
            
        }

        private string TryLogin()
        {
            if (File.Exists($"Users\\{userLogin.Text}.txt"))
            {
                using (StreamReader sr = new StreamReader($"Users\\{userLogin.Text}.txt"))
                {
                    while (sr.Peek() > 0)
                    {
                        string currentLine = sr.ReadLine();
                        if (currentLine.Contains($"{userLogin.Text}") && sr.ReadLine().Contains($"{userPassword.Text}"))
                        {
                            sr.ReadLine();
                            sr.ReadLine();
                            currentLine = sr.ReadLine();
                            if (currentLine.Contains("False"))
                                return "False";
                            else return "True";
                        }
                    }
                }
            }
            return "";
        }

        private void userLoginBox_Enter(object sender, EventArgs e)
        {
            if (userLogin.ForeColor != Color.Gray)
                return;
            userLogin.Text = string.Empty;
            userLogin.ForeColor = Color.Black;
        }

        private void userLoginBox_Leave(object sender, EventArgs e)
        {
            if (userLogin.Text != string.Empty)
                return;
            userLogin.Text = "Логин";
            userLogin.ForeColor = Color.Gray;
        }

        private void userPasswordBox_Enter(object sender, EventArgs e)
        {
            if (userPassword.ForeColor != Color.Gray)
                return;
            userPassword.Text = string.Empty;
            userPassword.ForeColor = Color.Black;
            userPassword.UseSystemPasswordChar = true;
        }

        private void userPasswordBox_Leave(object sender, EventArgs e)
        {
            if (userPassword.Text != string.Empty)
                return;
            userPassword.Text = "Пароль";
            userPassword.ForeColor = Color.Gray;
            userPassword.UseSystemPasswordChar = false;
        }
    }
}
