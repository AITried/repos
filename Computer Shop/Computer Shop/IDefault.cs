using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop
{
    internal interface IDefault
    {
        List<object> Data { get; set; }

        void loadData(List<object> data);
    }
}
