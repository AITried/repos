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
    public partial class newGoodForm : proxyForm
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
            goodNameBox.Text = data[1].ToString();
            typeBox.Text = data[2].ToString();
            firstPriceBox.Text = data[3].ToString();
            secondPriceBox.Text= data[4].ToString();
            countBox.Text = data[5].ToString();

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

        public newGoodForm()
        {
            InitializeComponent();
        }

        private void newGoodForm_Load(object sender, EventArgs e)
        {

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

        private void goodNameBox_Enter(object sender, EventArgs e)
        {
            goodNameLabel.Visible = false;
        }

        private void goodNameBox_Leave(object sender, EventArgs e)
        {

        }

        private void firstPriceBox_Enter(object sender, EventArgs e)
        {
            firstPriceLabel.Visible = false;
        }

        private void firstPriceBox_Leave(object sender, EventArgs e)
        {

        }

        private void secondPriceBox_Enter(object sender, EventArgs e)
        {
            secondPriceLabel.Visible= false;
        }

        private void secondPriceBox_Leave(object sender, EventArgs e)
        {

        }

        private void typeBox_Enter(object sender, EventArgs e)
        {
            typeLabel.Visible = false;
        }

        private void typeBox_Leave(object sender, EventArgs e)
        {

        }

        private void countBox_Enter(object sender, EventArgs e)
        {
            countlabel.Visible = false;
        }

        private void countBox_Leave(object sender, EventArgs e)
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

        private void addNoChange(object sender, EventArgs e)
        {
            string name = goodNameBox.Text;
            string type = typeBox.Text;

            double firstPrice;
            if (!Double.TryParse(firstPriceBox.Text, out firstPrice))
            {
                MessageBox.Show("Неверный формат цены закупки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            double secondPrice;
            if (!Double.TryParse(secondPriceBox.Text, out secondPrice))
            {
                MessageBox.Show("Неверный формат цены продажи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int count;
            if (!Int32.TryParse(countBox.Text, out count))
            {
                MessageBox.Show("Неверный формат количества!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (name.Length == 0)
            {
                MessageBox.Show("Введите название правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (type.Length == 0)
            {
                MessageBox.Show("Введите тип правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (firstPrice < 0)
            {
                MessageBox.Show("Введите цену закупки!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (secondPrice < 0)
            {
                MessageBox.Show("Введите цену продажи правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (count < 0)
            {
                MessageBox.Show("Введите количество правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();

            DataTable dataTable = dataBaseWorker.checkInstanceGetTable("ТипыТоваров", "ТипТовара", type);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Такого типа товара нет!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object[] datas = new object[] { name, type, firstPrice, secondPrice, count };

            if (dataBaseWorker.insertRow("Товары", datas))
            {
                MessageBox.Show("Товар успешно добавлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addChange(object sender, EventArgs e)
        {
            string name = goodNameBox.Text;
            string type = typeBox.Text;

            double firstPrice;
            if (!Double.TryParse(firstPriceBox.Text, out firstPrice))
            {
                MessageBox.Show("Неверный формат цены закупки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            double secondPrice;
            if (!Double.TryParse(secondPriceBox.Text, out secondPrice))
            {
                MessageBox.Show("Неверный формат цены продажи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int count;
            if (!Int32.TryParse(countBox.Text, out count))
            {
                MessageBox.Show("Неверный формат количества!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (name.Length == 0)
            {
                MessageBox.Show("Введите название правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (type.Length == 0)
            {
                MessageBox.Show("Введите тип правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (firstPrice < 0)
            {
                MessageBox.Show("Введите цену закупки!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (secondPrice < 0)
            {
                MessageBox.Show("Введите цену продажи правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (count < 0)
            {
                MessageBox.Show("Введите количество правильно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();

            DataTable dataTable = dataBaseWorker.checkInstanceGetTable("ТипыТоваров", "ТипТовара", type);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Такого типа товара нет!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object[] datas = new object[] { id, name, type, firstPrice, secondPrice, count };

            if (dataBaseWorker.updateRow("Товары", datas) > 0)
            {
                MessageBox.Show("Товар успешно добавлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                closeButton_Click(sender, e);
                return;
            }
            MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
