using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop
{
    public partial class newUserForm : proxyForm
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        public List<object> Data { get; set; }
        bool isChangeState = false;
        string id = "";

        public override void loadData(List<object> data)
        {
            Data = data;

            id = data[0].ToString();
            userNameBox.Text = data[1].ToString();
            userSurnameBox.Text = data[2].ToString();
            userFatherNameBox.Text = data[3].ToString();
            userAddBox.SelectedIndex = userAddBox.Items.IndexOf(data[4].ToString());
            userPhoneBox.Text = data[5].ToString();
            userLoginBox.Text = data[6].ToString();
            userPassBox.Text = data[7].ToString();

            isChangeState = true;
        }

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

        public newUserForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (isChangeState)
            {
                addChange(sender, e);
                return;
            }
            addNoChange(sender, e);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            isChangeState = false;
            Close();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void addNoChange(object sender, EventArgs e)
        {
            string name = userNameBox.Text;
            string surname = userSurnameBox.Text;
            string fatherName = userFatherNameBox.Text;
            string phone = userPhoneBox.Text;
            string login = userLoginBox.Text;
            string pass = userPassBox.Text;
            string user = userAddBox.Text;

            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Введите имя!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(surname))
                {
                    MessageBox.Show("Введите фамилию!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(fatherName))
                {
                    MessageBox.Show("Введите отчество!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(login))
                {
                    MessageBox.Show("Введите логин!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(phone))
                {
                    MessageBox.Show("Введите телефон!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Введите пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Введите должность!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataBaseWorker dataBaseWorker = new DataBaseWorker();

                DataTable nowDataTable = dataBaseWorker.checkInstanceGetTable("Сотрудники", "Логин", login);
                if (nowDataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] datas = new string[] { surname, name, fatherName, user, phone, login, pass };

                if (dataBaseWorker.insertRow("Сотрудники", datas))
                {
                    MessageBox.Show("Пользователь добавлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void addChange(object sender, EventArgs e)
        {
            string name = userNameBox.Text;
            string surname = userSurnameBox.Text;
            string fatherName = userFatherNameBox.Text;
            string phone = userPhoneBox.Text;
            string login = userLoginBox.Text;
            string pass = userPassBox.Text;
            string user = userAddBox.Text;

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Введите имя!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(surname))
                {
                    MessageBox.Show("Введите фамилию!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(fatherName))
                {
                    MessageBox.Show("Введите отчество!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(login))
                {
                    MessageBox.Show("Введите логин!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(phone))
                {
                    MessageBox.Show("Введите телефон!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Введите пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Введите должность!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataBaseWorker dataBaseWorker = new DataBaseWorker();

                string[] datas = new string[] { id, surname, name, fatherName, user, phone, login, pass };

                if (dataBaseWorker.updateRow("Сотрудники", datas) > 0)
                {
                    MessageBox.Show("Пользователь изменён!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    closeButton_Click(sender, e);
                    return;
                }
                MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void newUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
