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
    public partial class newGiversForm : proxyForm
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
            companyNameBox.Text = data[1].ToString();
            companyAdressBox.Text = data[2].ToString();
            companyPostBox.Text = data[3].ToString();
            companyPhoneBox.Text = data[4].ToString();

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

        public newGiversForm()
        {
            InitializeComponent();
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (isChangeState)
            {
                addChange(sender, e);
                return;
            }
            addNoChange(sender, e);
        }

        private void addNoChange(object sender, EventArgs e)
        {
            string name = companyNameBox.Text;
            string adress = companyAdressBox.Text;
            string post = companyPostBox.Text;
            string phone = companyPhoneBox.Text;

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите название!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(adress))
            {
                MessageBox.Show("Введите адрес!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(post))
            {
                MessageBox.Show("Введите почту!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Введите телефон!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();

            DataTable dataTable = dataBaseWorker.checkInstanceGetTable("Поставщики", "НазваниеКомпании", name);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Компания с таким названием уже существует!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] datas = new string[] { name, adress, post, phone };

            if (dataBaseWorker.insertRow("Поставщики", datas))
            {
                MessageBox.Show("Компания добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addChange(object sender, EventArgs  e)
        {
            string name = companyNameBox.Text;
            string adress = companyAdressBox.Text;
            string post = companyPostBox.Text;
            string phone = companyPhoneBox.Text;

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите название!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(adress))
            {
                MessageBox.Show("Введите адрес!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(post))
            {
                MessageBox.Show("Введите почту!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Введите телефон!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();

            string[] datas = new string[] { id, name, adress, post, phone };

            if (dataBaseWorker.updateRow("Поставщики", datas) > 0)
            {
                MessageBox.Show("Компания добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                closeButton_Click(sender, e);
                return;
            }
            MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void newGiversForm_Load(object sender, EventArgs e)
        {

        }
    }
}
