using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop
{
    public partial class newOrderForm : proxyForm
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        public List<object> Data = new List<object>();
        bool isChangeState = false;
        string id = ""; 

        public override void loadData(List<object> data)
        {
            Data = data;

            id = data[0].ToString();
            idBox.Text = data[1].ToString();
            surnameBox.Text = data[2].ToString();
            adressBox.Text = data[3].ToString();
            phoneBox.Text = data[4].ToString();
            dateTimePicker.Value = DateTime.ParseExact(data[5].ToString(), "dd.MM.yyyy H:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            isChangeState = true;
        }

        public void loadDataNoChange(List<object> data)
        {
            Data = data;

            idBox.Text = data[0].ToString();
            surnameBox.Text = data[1].ToString();
            adressBox.Text = data[2].ToString();
            phoneBox.Text = data[3].ToString();
            dateTimePicker.Value = DateTime.Now;
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

        public newOrderForm()
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

        private void adressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adressBox_Enter(object sender, EventArgs e)
        {
            adressLabel.Visible = false;
        }

        private void adressBox_Leave(object sender, EventArgs e)
        {
            if (adressBox.Text.Length == 0)
            {
                adressLabel.Visible = true;
            }
        }

        private void idBox_Enter(object sender, EventArgs e)
        {
            idLabel.Visible = false;
        }

        private void idBox_Leave(object sender, EventArgs e)
        {
            if (idBox.Text.Length == 0)
            {
                idLabel.Visible = true;
            }
        }

        private void phoneBox_Enter(object sender, EventArgs e)
        {
            phoneLabel.Visible = false;
        }

        private void phoneBox_Leave(object sender, EventArgs e)
        {
            if (phoneBox.Text.Length == 0)
            {
                phoneLabel.Visible = true;
            }
        }

        private void surnameBox_Enter(object sender, EventArgs e)
        {
            surnameLabel.Visible = false;
        }

        private void surnameBox_Leave(object sender, EventArgs e)
        {
            if (surnameBox.Text.Length == 0)
            {
                surnameLabel.Visible = true;
            }
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

        private void newOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void addNoChange(object sender, EventArgs e)
        {
            string id;
            if (Int32.TryParse(idBox.Text, out int _))
            {
                id = idBox.Text;
            }
            else
            {
                MessageBox.Show("Неверный формат ID!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string surname = surnameBox.Text;
            string adress = adressBox.Text;
            string phone = phoneBox.Text;
            string date = dateTimePicker.Value.ToString();

            if (date.Length == 0)
            {
                MessageBox.Show("Введите дату!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (surname.Length == 0)
            {
                MessageBox.Show("Введите фамилию!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (adress.Length == 0)
            {
                MessageBox.Show("Введите адрес!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (phone.Length == 0)
            {
                MessageBox.Show("Введите телефон!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (id.Length == 0)
            {
                MessageBox.Show("Введите ID!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();

            DataTable dataTable = dataBaseWorker.checkInstanceGetTable("Товары", "IDТовара", id);

            if ((int)dataTable.Rows[0].ItemArray[5] < 1)
            {
                MessageBox.Show("Товара нет на складе!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            string[] datas = new string[] { id, surname, adress, phone, date, "В обработке" };

            if (dataBaseWorker.insertRow("Заказы", datas))
            {
                MessageBox.Show("Заказ принят!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addChange(object sender, EventArgs e)
        {
            string id;
            if (Int32.TryParse(idBox.Text, out int _))
            {
                id = idBox.Text;
            }
            else
            {
                MessageBox.Show("Неверный формат ID!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string surname = surnameBox.Text;
            string adress = adressBox.Text;
            string phone = phoneBox.Text;
            string date = dateTimePicker.Value.ToString();

            if (date.Length == 0)
            {
                MessageBox.Show("Введите дату!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (surname.Length == 0)
            {
                MessageBox.Show("Введите фамилию!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (adress.Length == 0)
            {
                MessageBox.Show("Введите адрес!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (phone.Length == 0)
            {
                MessageBox.Show("Введите телефон!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (id.Length == 0)
            {
                MessageBox.Show("Введите ID!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();

            DataTable dataTable = dataBaseWorker.checkInstanceGetTable("Товары", "IDТовара", id);

            if ((int)dataTable.Rows[0].ItemArray[5] < 1)
            {
                MessageBox.Show("Товара нет на складе!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            string[] datas = new string[] { this.id, id, surname, adress, phone, date, "В обработке" };

            if (dataBaseWorker.updateRow("Заказы", datas) > 0)
            {
                MessageBox.Show("Заказ принят!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                closeButton_Click(sender, e);
                return;
            }
            MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
