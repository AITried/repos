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
    public partial class newRevisionForm : proxyForm
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
            dateTimePicker.Value = DateTime.ParseExact(data[1].ToString(), "dd.MM.yyyy H:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            idWorkerBox.Text = data[2].ToString();
            moneyBox.Text = data[3].ToString();

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

        public newRevisionForm()
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

        private void idWorkerBox_Enter(object sender, EventArgs e)
        {
            idWorkerLabel.Visible = false;
        }

        private void idWorkerBox_Leave(object sender, EventArgs e)
        {

        }

        private void moneyBox_Enter(object sender, EventArgs e)
        {
            moneyLabel.Visible = false;
        }

        private void moneyBox_Leave(object sender, EventArgs e)
        {

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

        private void newRevisionForm_Load(object sender, EventArgs e)
        {

        }

        private void addNoChange(object sender, EventArgs e)
        {
            int idWorker;
            if (!Int32.TryParse(idWorkerBox.Text, out idWorker))
            {
                MessageBox.Show("Неверный формат ID сотрудника!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int money;
            if (!Int32.TryParse(moneyBox.Text, out money))
            {
                MessageBox.Show("Неверный формат недостачи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string date = dateTimePicker.Value.ToString();

            if (date.Length == 0)
            {
                MessageBox.Show("Введите дату правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (idWorker < 0)
            {
                MessageBox.Show("Введите ID сотрудника правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();

            DataTable dataTable = dataBaseWorker.checkInstanceGetTable("Сотрудники", "IDСотрудника", idWorker);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Такого сотрудника не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object[] datas = new object[] { date, idWorker, money };
            if (dataBaseWorker.insertRow("Ревизии", datas))
            {
                MessageBox.Show("Ревизия добавлена успешно!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addChange(object sender, EventArgs e)
        {
            int idWorker;
            if (!Int32.TryParse(idWorkerBox.Text, out idWorker))
            {
                MessageBox.Show("Неверный формат ID сотрудника!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int money;
            if (!Int32.TryParse(moneyBox.Text, out money))
            {
                MessageBox.Show("Неверный формат недостачи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string date = dateTimePicker.Value.ToString();

            if (date.Length == 0)
            {
                MessageBox.Show("Введите дату правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (idWorker < 0)
            {
                MessageBox.Show("Введите ID сотрудника правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();

            DataTable dataTable = dataBaseWorker.checkInstanceGetTable("Сотрудники", "IDСотрудника", idWorker);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Такого сотрудника не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object[] datas = new object[] { id, date, idWorker, money };
            if (dataBaseWorker.updateRow("Ревизии", datas) > 0)
            {
                MessageBox.Show("Ревизия добавлена успешно!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                closeButton_Click(sender, e);
                return;
            }
            MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 
    }
}
