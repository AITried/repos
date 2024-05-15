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
    public partial class newGainsForm : proxyForm
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        public List<object> Data { get; set; }
        bool isChangeState = false;
        string id = "";

        int oldCount = 0;

        public override void loadData(List<object> data)
        {
            Data = data;

            id = data[0].ToString();
            idGiverBox.Text = data[1].ToString();
            idGoodBox.Text = data[2].ToString();
            dateTimePicker.Value = DateTime.ParseExact(data[3].ToString(), "dd.MM.yyyy H:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            countBox.Text = data[4].ToString();
            Int32.TryParse(countBox.Text, out oldCount);

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

        public newGainsForm()
        {
            InitializeComponent();
        }

        private void idGoodBox_TextChanged(object sender, EventArgs e)
        {
            idGoodLabel.Visible = false;
        }

        private void idGoodBox_Enter(object sender, EventArgs e)
        {
            idGoodLabel.Visible = false;
        }

        private void idGoodBox_Leave(object sender, EventArgs e)
        {
            if (idGoodBox.Text.Length == 0)
            {
                idGoodLabel.Visible = true;
            }
        }

        private void countBox_Enter(object sender, EventArgs e)
        {
            countlabel.Visible = false;
        }

        private void countBox_Leave(object sender, EventArgs e)
        {
            if (countBox.Text.Length == 0)
            {
                countlabel.Visible = true;
            }
        }

        private void idGiverBox_Enter(object sender, EventArgs e)
        {
            idGiverLabel.Visible = false;
        }

        private void idGiverBox_Leave(object sender, EventArgs e)
        {
            if (idGiverBox.Text.Length == 0)
            {
                idGiverLabel.Visible = true;
            }
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

        private void newGainsForm_Load(object sender, EventArgs e)
        {

        }

        private void addNoChange(object sender, EventArgs e)
        {
            int goodId;
            if (!Int32.TryParse(idGoodBox.Text, out goodId))
            {
                MessageBox.Show("Неверный формат ID товара!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int giverId;
            if (!Int32.TryParse(idGiverBox.Text, out giverId))
            {
                MessageBox.Show("Неверный формат ID поставщика!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int count;
            if (!Int32.TryParse(countBox.Text, out count))
            {
                MessageBox.Show("Неверный формат количества товара!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string date = dateTimePicker.Value.ToString();

            if (date.Length == 0)
            {
                MessageBox.Show("Введите дату правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (goodId < 0)
            {
                MessageBox.Show("Введите ID товара правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (giverId < 0)
            {
                MessageBox.Show("Введите ID поставщика правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (count < 0)
            {
                MessageBox.Show("Введите количество правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();

            DataTable dataTable = dataBaseWorker.checkInstanceGetTable("Товары", "IDТовара", goodId);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Такого товара не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataTable = dataBaseWorker.checkInstanceGetTable("Поставщики", "IDПоставщика", giverId);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Такого поставщика не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object[] datas = new object[] { giverId, goodId, date, count };

            if (dataBaseWorker.insertRow("Поставки", datas) && dataBaseWorker.plusRow("Товары", "IDТовара", goodId, "КоличествоНаСкладе", count) > 0)
            {
                MessageBox.Show("Поставка добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addChange(object sender, EventArgs e)
        {
            int goodId;
            if (!Int32.TryParse(idGoodBox.Text, out goodId))
            {
                MessageBox.Show("Неверный формат ID товара!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int giverId;
            if (!Int32.TryParse(idGiverBox.Text, out giverId))
            {
                MessageBox.Show("Неверный формат ID поставщика!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int count;
            if (!Int32.TryParse(countBox.Text, out count))
            {
                MessageBox.Show("Неверный формат количества товара!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string date = dateTimePicker.Value.ToString();

            if (date.Length == 0)
            {
                MessageBox.Show("Введите дату правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (goodId < 0)
            {
                MessageBox.Show("Введите ID товара правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (giverId < 0)
            {
                MessageBox.Show("Введите ID поставщика правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (count < 0)
            {
                MessageBox.Show("Введите количество правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();

            DataTable dataTable = dataBaseWorker.checkInstanceGetTable("Товары", "IDТовара", goodId);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Такого товара не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataTable = dataBaseWorker.checkInstanceGetTable("Поставщики", "IDПоставщика", giverId);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Такого поставщика не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object[] datas = new object[] { id, giverId, goodId, date, count };

            count -= oldCount;

            if (dataBaseWorker.updateRow("Поставки", datas) > 0 && dataBaseWorker.plusRow("Товары", "IDТовара", goodId, "КоличествоНаСкладе", count) > 0)
            {
                MessageBox.Show("Поставка добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                closeButton_Click(sender, e);
                return;
            }
            MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
