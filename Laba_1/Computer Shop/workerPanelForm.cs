using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Computer_Shop
{
    public partial class workerPanelForm : Form
    {
        string adminSurname;
        string adminUser;
        DataBaseWorker dataBaseWorker = new DataBaseWorker();
        proxyForm[] forms = new proxyForm[] { new newGiversForm(), new newOrderForm(), new newCancelForm(), new newGainsForm(), new newRevisionForm(), new newGoodTypeForm(), new newGoodForm() };

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

        public workerPanelForm()
        {
            InitializeComponent();
        }

        public workerPanelForm(string adminUser, string adminSurname)
        {
            InitializeComponent();
            this.adminSurname = adminSurname;
            this.adminUser = adminUser;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            proxyForm newForm = forms[nowTableBox.SelectedIndex];
            newForm.ShowDialog();
        }

        private void workerPanelForm_Load(object sender, EventArgs e)
        {
            surnameBox.Text = adminSurname;
            userBox.Text = adminUser;

            nowTableBox.SelectedIndex = 0;

            DataTable dataTable = dataBaseWorker.selectAllTable("Поставщики");

            dataGridView.DataSource = dataTable;
        }

        private void nowTableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = dataBaseWorker.selectAllTable($"{nowTableBox.SelectedItem}");

            dataGridView.DataSource = dataTable;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();

            loginForm.Show();
            Close();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string table = nowTableBox.Items[nowTableBox.SelectedIndex].ToString();
            string columnName = dataGridView.Columns[0].Name;

            DataBaseWorker dataBaseWorker = new DataBaseWorker();

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                if (dataBaseWorker.deleteRow(table, columnName, row.Cells[0].Value.ToString()) == 0)
                {
                    MessageBox.Show("Неудачно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Записи удалены!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable dataTable = dataBaseWorker.selectAllTable($"{nowTableBox.SelectedItem}");

            dataGridView.DataSource = dataTable;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
                return;
            List<object> data = new List<object>();

            DataGridViewRow row = dataGridView.SelectedRows[0];

            foreach (DataGridViewCell cell in row.Cells)
            {
                data.Add(cell.Value.ToString());
            }

            proxyForm form = forms[nowTableBox.SelectedIndex];
            form.loadData(data);
            form.ShowDialog();
        }

        private void updateViewButton_Click(object sender, EventArgs e)
        {
            nowTableBox_SelectedIndexChanged(sender, e);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                    if (dataGridView.Rows[i].Cells[j].Value != null)
                        if (dataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchBox.Text))
                        {
                            dataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void wordButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "table.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                dataBaseWorker.exportDataToWord(dataGridView, sfd.FileName, (string)nowTableBox.Items[nowTableBox.SelectedIndex]);
            }
        }

        private void supportButton_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\glf12\\IdeaProjects\\Lab1\\Справка.html");
        }
    }
}
