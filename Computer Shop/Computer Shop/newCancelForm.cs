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
    public partial class newCancelForm : proxyForm
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

        public newCancelForm()
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

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newCancelForm_Load(object sender, EventArgs e)
        {
            if (idBox.Text.Length != 0)
            {
                idLabel.Visible = false;
            }
        }

        private void addNoChange(object sender, EventArgs e)
        {
            string id = null;

            if (Int32.TryParse(idBox.Text, out int _))
            {
                id = idBox.Text;
            }
            else
            {
                MessageBox.Show("Неверный формат ID!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (id.Length == 0)
            {
                MessageBox.Show("Введите ID!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();

            DataTable dataTable = dataBaseWorker.checkInstanceGetTable("Заказы", "IDЗаказа", id);

            if ((int)dataTable.Rows.Count < 1)
            {
                MessageBox.Show("Такого заказа нет!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            string[] datas = new string[] { id };

            if (dataBaseWorker.insertRow("Отмены", datas) && dataBaseWorker.updateRow("Заказы", "IDЗаказа", id, "СтатусЗаказа", "Отменён") > 0)
            {
                MessageBox.Show("Отмена принята!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addChange(object sender, EventArgs e)
        {
            string id = null;

            if (Int32.TryParse(idBox.Text, out int _))
            {
                id = idBox.Text;
            }
            else
            {
                MessageBox.Show("Неверный формат ID!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (id.Length == 0)
            {
                MessageBox.Show("Введите ID!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBaseWorker dataBaseWorker = new DataBaseWorker();

            DataTable dataTable = dataBaseWorker.checkInstanceGetTable("Заказы", "IDЗаказа", id);

            if ((int)dataTable.Rows.Count < 1)
            {
                MessageBox.Show("Такого заказа нет!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            string[] datas = new string[] { this.id, id };

            if (dataBaseWorker.updateRow("Отмены", datas) > 0 && dataBaseWorker.updateRow("Заказы", "IDЗаказа", id, "СтатусЗаказа", "Отменён") > 0)
            {
                MessageBox.Show("Отмена принята!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                closeButton_Click(sender, e);
                return;
            }
            MessageBox.Show("Добавить не удалось!", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void idBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
