namespace File_filter_system
{
    public partial class UserForm : Form
    {
        private string _currentUser;
        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(string currentLine)
        {
            InitializeComponent();

            LoadUserData(currentLine);
        }

        private void LoadUserData(string userLogin)
        {
            if (!File.Exists($"Users\\{userLogin}Info.txt"))
            {
                UpdateUserInfo("0", "0", userLogin);
            }

            using (StreamReader sr = new StreamReader($"Users\\{userLogin}Info.txt"))
            {

                profileEditCount.Text = sr.ReadLine();
                warningsCount.Text = sr.ReadLine();
            }

            using (StreamReader sr = new StreamReader($"Users\\{userLogin}.txt"))
            {
                userLoginBox.Text = sr.ReadLine();
                userPasswordBox.Text = sr.ReadLine();
                userNameBox.Text = sr.ReadLine();
                userSurnameBox.Text = sr.ReadLine();
            }

            label2.Text = userLogin;
            label12.Text = userLogin;
            _currentUser = userLogin;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string nameLogFile = "UserEditLogs";
            new EditProfileForm(userLoginBox.Text, userPasswordBox.Text, userNameBox.Text, userSurnameBox.Text, false).ShowDialog();
            profileEditCount.Text = (Int32.Parse(warningsCount.Text) + 1).ToString();
            UpdateUserInfo(profileEditCount.Text, warningsCount.Text, _currentUser);
            LoadUserData(userLoginBox.Text);
            UpdateLogInfo("���", userNameBox.Text, nameLogFile);
            UpdateLogInfo("�������", userSurnameBox.Text, nameLogFile);
            UpdateLogInfo("�����", userLoginBox.Text, nameLogFile);
            UpdateLogInfo("������", userPasswordBox.Text, nameLogFile);
        }

        private void UpdateLogInfo(string message, string dataToLog, string user)
        {
            DateTime time;
            time = DateTime.Now;
            using (StreamWriter sw = new StreamWriter($"Users\\{user}.txt", true))
            {
                sw.WriteLine($"{message} - {dataToLog}: {time.ToShortTimeString()}\n");
            }
        }

        private void UpdateUserInfo(string edits, string warnings, string user)
        {
            using (StreamWriter sw = new StreamWriter($"Users\\{user}Info.txt"))
            {
                sw.Write($"\n{edits}\n{warnings}\n");
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

        private void showPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                directoryBox.Text = fbd.SelectedPath;
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            // �������� ���� �� ���������� ����
            string path = directoryBox.Text;

            // �������� ����� ��� ����������
            string[] filterWords = filterTextBox.Text.Split(' ');

            // �������� ������������ ������ �����
            int maxSize = (int)maxFileSizeNumeric.Value * 1024 * 1024;

            // ���� ����� �� �������
            List<string> filteredFiles = GetFilteredFiles(path, filterWords, maxSize);
            string filesList = string.Join("\n", filteredFiles);

            DialogResult result = MessageBox.Show(
            $"������� ��������� �����:\n{filesList}\n\n������� ��?",
            "�������������",
            MessageBoxButtons.YesNo);
            // ���� ������������ ���������� �������� - �������
            if (result == DialogResult.Yes)
            {
                DeleteFiles(filteredFiles);
                MessageBox.Show("����� ������� �������");
            }
        }
        // ����� ��� ������ ������ �� �������
        List<string> GetFilteredFiles(string path, string[] filterWords, int maxSize)
        {
            List<string> filteredFiles = new List<string>();

            foreach (string filePath in Directory.GetFiles(path))
            {
                FileInfo fileInfo = new FileInfo(filePath);

                if (fileInfo.Length <= maxSize &&
                    filterWords.Any(w => fileInfo.Name.Contains(w)))
                {
                    filteredFiles.Add(filePath);
                }
            }

            return filteredFiles;
        }
        // ����� ��� �������� ������
        void DeleteFiles(List<string> filesToDelete)
        {
            foreach (string file in filesToDelete)
            {
                File.Delete(file);
            }
        }
    }


}