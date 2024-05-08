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
    public partial class newBreakForm : proxyForm
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
            masterIdBox.Text = data[1].ToString();
            idBox.Text = data[2].ToString();
            dateTimePicker.Value = DateTime.ParseExact(data[3].ToString(), "dd.MM.yyyy H:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            canBeFixedCheckBox.Checked = data[4].ToString() == "Да";

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
        public newBreakForm()
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

        private void newBreakForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (isChangeState)
            {
                addChange(sender, e);
                isChangeState = false;
                return;
            }
            addNoChange(sender, e);
        }

        private void addNoChange(object sender, EventArgs e)
        {
            int masterId;
            if (!Int32.TryParse(masterIdBox.Text, out masterId))
            {
                MessageBox.Show("Неверный формат ID мастера!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int goodsId;
            if (!Int32.TryParse(idBox.Text, out goodsId))
            {
                MessageBox.Show("Неверный формат ID товара!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string date = dateTimePicker.Value.ToString();
            string canBeFixed = (canBeFixedCheckBox.Checked ? "Да" : "Нет");

            if (masterId < 0)
            {
                MessageBox.Show("Введите ID мастера правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (goodsId < 0)
            {
                MessageBox.Show("Введите ID товара правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (date.Length == 0)
            {
                MessageBox.Show("Введите дату!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();

            DataTable dataTable = dataBaseWorker.checkInstanceGetTable("Сотрудники", "IDСотрудника", masterId);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Такого сотрудника нет!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataTable = dataBaseWorker.checkInstanceGetTable("Товары", "IDТовара", goodsId);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Такого товара нет!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object[] datas = new object[] { masterId, goodsId, date, canBeFixed };

            if (dataBaseWorker.insertRow("Поломки", datas) && dataBaseWorker.decrementRow("Товары", "IDТовара", goodsId, "КоличествоНаСкладе") > 0)
            {
                MessageBox.Show("Поломка учтена!", "Кспех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addChange(object sender, EventArgs e)
        {
            int masterId;
            if (!Int32.TryParse(masterIdBox.Text, out masterId))
            {
                MessageBox.Show("Неверный формат ID мастера!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int goodsId;
            if (!Int32.TryParse(idBox.Text, out goodsId))
            {
                MessageBox.Show("Неверный формат ID товара!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string date = dateTimePicker.Value.ToString();
            string canBeFixed = (canBeFixedCheckBox.Checked ? "Да" : "Нет");

            if (masterId < 0)
            {
                MessageBox.Show("Введите ID мастера правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (goodsId < 0)
            {
                MessageBox.Show("Введите ID товара правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (date.Length == 0)
            {
                MessageBox.Show("Введите дату!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();

            DataTable dataTable = dataBaseWorker.checkInstanceGetTable("Сотрудники", "IDСотрудника", masterId);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Такого сотрудника нет!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataTable = dataBaseWorker.checkInstanceGetTable("Товары", "IDТовара", goodsId);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Такого товара нет!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object[] datas = new object[] { id, masterId, goodsId, date, canBeFixed };

            if (dataBaseWorker.updateRow("Поломки", datas) > 0)
            {
                MessageBox.Show("Поломка учтена!", "Кспех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                closeButton_Click(sender, e);
                return;
            }
            MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
