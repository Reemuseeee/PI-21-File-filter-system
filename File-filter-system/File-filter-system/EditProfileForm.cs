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
    public partial class EditProfileForm : Form
    {
        private string _currentUser;
        private string _password;
        private bool _admin;
        public EditProfileForm()
        {
            InitializeComponent();
        }

        public EditProfileForm(string login, string password, string name, string surname, bool admin)
        {
            InitializeComponent();
            editNameBox.Text = name;
            editSurnameBox.Text = surname;
            editLoginBox.Text = login;
            _currentUser = login;
            _admin = admin;
            _password = password;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (userPasswordBox.Text != _password)
            {
                MessageBox.Show("Введён неправильный текущий пароль.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (editLoginBox.Text != _currentUser)
            {
                foreach (string filepath in Directory.GetFiles("Users", "*.txt"))
                {
                    if (Path.GetFileNameWithoutExtension(filepath).Contains(editLoginBox.Text))
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует.", "Ошибка редактирования", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            UpdateUserData(editLoginBox.Text, userRPasswordBox.Text, editNameBox.Text, editSurnameBox.Text);
            UpdateLogInfo("Пользователь отредактировал своё имя на: " + editNameBox.Text + " ,пароль на: " + userRPasswordBox.Text + " ,логин на: " + editLoginBox.Text + " ,фамилию на: " + editSurnameBox.Text, _currentUser);
            MessageBox.Show("Данные успешно изменены.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void UpdateUserData(string login, string password, string name, string surname)
        {
            using (StreamWriter sw = new StreamWriter($"Users\\{login}.txt"))
            {
                sw.Write($"{login}\n{password}\n{name}\n{surname}\n{_admin}\n");
                sw.Close();
            }
        }

        private void UpdateLogInfo(string messageToLog, string user)
        {
            DateTime time;
            time = DateTime.Now;
            using (StreamWriter sw = new StreamWriter($"Users\\{user}Log.txt", true))
            {
                sw.Write($"{messageToLog} ; {time.ToShortTimeString()}\n");
            }
        }
    }
}
