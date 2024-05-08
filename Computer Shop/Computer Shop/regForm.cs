using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop
{
    public partial class regForm : Form
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
        public regForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void backButton_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();

            loginForm.Show();
            Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            accessLabel.Visible = false;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                accessLabel.Visible = false;
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string login = LogBox.Text;
            string pass = PassBox.Text;
            string accessPass = textBox1.Text;

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Введите логин!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Введите пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PassBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(accessPass))
            {
                MessageBox.Show("Введите подтверждение пароля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            if (pass != accessPass)
            {
                MessageBox.Show("Пароли не совпадают!", "Неверно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();
            DataTable dataTable = dataBaseWorker.checkInstanceGetTable("Сотрудники", "Логин", login);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object[] datas = new object[] { "Анонимный клиент", "Анонимный клиент", "Анонимный клиент", "Клиент", "Не указан", login, pass }; 

            if (dataBaseWorker.insertRow("Сотрудники", datas))
            {
                MessageBox.Show("Регистрация прошла успешно!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Что-то пошло не так!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}
