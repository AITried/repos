using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3TIO
{
    public class Isbelong
    {
        public double TestPoints(double x, double y)
        {
            double r = 2.0;
            double distance2 = Math.Sqrt((Math.Pow((x - 2), 2) + (Math.Pow((y + 2), 2))));
            double distance4 = Math.Sqrt((Math.Pow((x + 2), 2) + (Math.Pow((y - 2), 2))));
            if ((distance2 > r) && x > 0 && y < 0 && x < 2 && y > -2)
            {
                return 2;
            }
            else if ((distance4 > r) && x < 0 && y > 0 && x > -2.0 && y < 2.0)
            {
                return 4;
            }

            else { return 0; }

        }
    }
}
