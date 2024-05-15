using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop
{
    public partial class supportForm : Form
    {
        string parent;
        public supportForm()
        {
            InitializeComponent();
        }

        public supportForm(string parent)
        {
            InitializeComponent();

            this.parent = parent;
        }

        private void supportForm_Load(object sender, EventArgs e)
        {
            string file;
            if (parent == "Клиент") 
            {
                file = "СправкаКлиент.txt";
            }
            else
            {
                file = "Справка.txt";
            }
            supportTextBox.Text = File.ReadAllText("C:\\Users\\glf12\\source\\repos\\Computer Shop\\Computer Shop\\" + file);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
