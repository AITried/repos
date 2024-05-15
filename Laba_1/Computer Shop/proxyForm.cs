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
    public partial class proxyForm : Form, IDefault
    {
        public List<object> Data { get; set; }

        public virtual void loadData(List<object> data)
        {
            Data = data;
        }

        private void proxyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
