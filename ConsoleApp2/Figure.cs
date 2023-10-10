using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Figure
    {
        protected List<Point> pList;
        public void Drow()
        {
            foreach (Point point in pList)
            {
                point.Draw();
            }
        }
    }
}
