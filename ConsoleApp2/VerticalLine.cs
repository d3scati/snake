using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class VerticalLine : Figure
    {
        public VerticalLine(int yDown, int yUp, int x, char symb)
        {
            pList = new List<Point>();
            for (int y = yDown; y <= yUp; y++)
            {
                Point point = new Point(x, y, symb);
                pList.Add(point);
            }
        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            base.Draw();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
