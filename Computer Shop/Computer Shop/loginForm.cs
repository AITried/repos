using System;
using System.Data;
using System.Windows.Forms;

namespace Computer_Shop
{
    public partial class loginForm : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);

                    if ((int)m.Result == HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                    return;
            }

            base.WndProc(ref m);
        }

        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogBox.Text = Properties.Settings.Default.Login;
            PassBox.Text = Properties.Settings.Default.Pass;

            if (LogBox.Text.Length > 0)
            {
                logLabel.Visible = false;
                rememberCheckBox.Checked = true;
            }
            if (PassBox.Text.Length > 0)
            {
                passLabel.Visible = false;
                rememberCheckBox.Checked = true;
            }
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            string login = LogBox.Text;
            string pass = PassBox.Text;

            if (rememberCheckBox.Checked)
            {
                Properties.Settings.Default.Login = login;
                Properties.Settings.Default.Pass = pass;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Login = "";
                Properties.Settings.Default.Pass = "";
                Properties.Settings.Default.Save();
            }

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Введите логин!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Введите пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();
            DataTable dataTable = dataBaseWorker.checkInstanceGetTable("Сотрудники", "Логин", login);

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Такого пользователя не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string actualPass = (string)dataTable.Rows[0].ItemArray[7];
            string work = (string)dataTable.Rows[0].ItemArray[4];
            string name = (string)dataTable.Rows[0].ItemArray[1];
            if (dataTable.Rows.Count > 0 && actualPass == pass)
            {
                Form main = null;
                switch(work)
                {
                    case "Админ":
                        main = new adminPanelForm(work, name);
                        break;

                    case "Продавец":
                        main = new workerPanelForm(work, name);
                        break;

                    case "Техник":
                        main = new techPanelForm(work, name);
                        break;

                    case "Клиент":
                        main = new clientPanelForm(work, login);
                        break;

                    default:
                        MessageBox.Show("Ошибка должности!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                main.Show();
                Hide();
                return;
            }
            else if(dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Неверный логин!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                MessageBox.Show("Неверный пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
             }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();

            Application.Exit();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void LogBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogBox_Enter(object sender, EventArgs e)
        {
            logLabel.Visible = false;
        }

        private void LogBox_Leave(object sender, EventArgs e)
        {
            if (LogBox.Text.Length == 0)
            {
                logLabel.Visible = true;
            }
        }

        private void PassBox_Enter(object sender, EventArgs e)
        {
            passLabel.Visible = false;
        }

        private void PassBox_Leave(object sender, EventArgs e)
        {
            if (PassBox.Text.Length == 0)
            {
                passLabel.Visible = true;
            }
        }

        private void rememberCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logLabel_Click(object sender, EventArgs e)
        {

        }

        private void passLabel_Click(object sender, EventArgs e)
        {

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            new regForm().Show();
            Hide();
        }
    }
}
