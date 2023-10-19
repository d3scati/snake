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
        public virtual void Draw()
        {
            foreach (Point point in pList)
            {
                point.Draw();
            }
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var point in pList)
            {
                if (figure.IsHit(point))
                    return true;
            }
            return false;
        }
        internal bool IsHit(Point point1)
        {
            foreach (var point in pList)
            {
                if (point1.IsHit(point))
                    return true;
            }
            return false;
        }

    }
}
