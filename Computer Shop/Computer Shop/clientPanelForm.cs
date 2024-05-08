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

namespace Computer_Shop
{
    public partial class clientPanelForm : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        DataBaseWorker dataBaseWorker = new DataBaseWorker();

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

        public clientPanelForm()
        {
            InitializeComponent();
        }

        public clientPanelForm(string login, string status)
        {
            InitializeComponent();

            loginBox.Text = login;
            statusBox.Text = status;
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

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
                return;

            List<object> data = new List<object>();

            DataGridViewRow row = dataGridView.SelectedRows[0];

            data.Add(row.Cells[0].Value.ToString());
            data.Add("");
            data.Add("");
            data.Add("");


            newOrderForm newOrderForm = new newOrderForm();
            newOrderForm.loadDataNoChange(data);
            newOrderForm.ShowDialog();
        }

        private void clientPanelForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = dataBaseWorker.selectAllTable("ТоварыКлиент");

            dataGridView.DataSource = dataTable;
        }

        private void updateViewButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = dataBaseWorker.selectAllTable("ТоварыКлиент"); 

            dataGridView.DataSource = dataTable;
        }

        private void supportButton_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\glf12\\IdeaProjects\\Lab1\\СправкаПоль.html");
        }
    }
}
