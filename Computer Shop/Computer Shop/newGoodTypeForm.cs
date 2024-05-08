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
    public partial class newGoodTypeForm : proxyForm
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        public List<object> Data { get; set; }
        bool isChangeState = false;

        public override void loadData(List<object> data)
        {
            Data = data;

            goodTypeBox.Text = data[0].ToString();
            percentBox.Text = data[1].ToString();
            techBox.Checked = data[2].ToString() == "Да";

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

        public newGoodTypeForm()
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

        private void goodTypeBox_Enter(object sender, EventArgs e)
        {
            goodTypeLabel.Visible = false;
        }

        private void goodTypeBox_Leave(object sender, EventArgs e)
        {

        }

        private void percentBox_Enter(object sender, EventArgs e)
        {
            percentLabel.Visible = false;
        }

        private void percentBox_Leave(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (isChangeState)
            {
                addChange(sender, e);
                return;
            }
            addChange(sender, e);
        }

        private void newGoodTypeForm_Load(object sender, EventArgs e)
        {

        }

        private void addNoChange(object sender, EventArgs e)
        {
            bool hardGood = false;
            if (techBox.Checked)
            {
                hardGood = true;
            }
            string hardGoodStr = hardGood ? "Да" : "Нет";

            string type = goodTypeBox.Text;

            int percent;
            if (!Int32.TryParse(percentBox.Text, out percent))
            {
                MessageBox.Show("Неверный формат процента!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();

            DataTable dataTable = dataBaseWorker.checkInstanceGetTable("ТипыТоваров", "ТипТовара", type);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Такой тип товара уже есть!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object[] datas = new object[] { type, percent, hardGoodStr };

            if (dataBaseWorker.insertRow("ТипыТоваров", datas))
            {
                MessageBox.Show("Тип товара успешно добавлен!", "Успкех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addChange(object sender, EventArgs e)
        {
            bool hardGood = false;
            if (techBox.Checked)
            {
                hardGood = true;
            }
            string hardGoodStr = hardGood ? "Да" : "Нет";

            string type = goodTypeBox.Text;

            int percent;
            if (!Int32.TryParse(percentBox.Text, out percent))
            {
                MessageBox.Show("Неверный формат процента!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();

            object[] datas = new object[] { type, percent, hardGoodStr };

            if (dataBaseWorker.updateRow("ТипыТоваров", datas) > 0)
            {
                MessageBox.Show("Тип товара успешно изменён!", "Успкех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                closeButton_Click(sender, e);
                return;
            }
            MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
