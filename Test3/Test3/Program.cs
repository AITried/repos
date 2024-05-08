using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    public enum FigureArea
    {
        Circles,
        Square,
        Outside
    }

    public class PointFigure
    {
        public double R;

        public FigureArea TestPoint(double x, double y)
        {
            if (x >= 0 && x <= R && y >= 0 && y <= R ||
                x >= -R && x <= 0 && y >= -R && y <= 0 ||
                x >= -R && x <= 0 && y >= 0 && y <= R && Math.Pow(x + R, 2) + Math.Pow(y - R, 2) >= R * R ||
                x >= 0 && x <= R && y >= -R && y <= 0 && Math.Pow(x - R, 2) + Math.Pow(y + R, 2) >= R * R)
            {
                return FigureArea.Square;
            }
            else if (Math.Pow(x + R, 2) + Math.Pow(y - R, 2) <= R * R ||
                     Math.Pow(x - R, 2) + Math.Pow(y + R, 2) <= R * R)
            {
                return FigureArea.Circles;
            }
            else
            {
                return FigureArea.Outside;
            }
        }
    }
}
