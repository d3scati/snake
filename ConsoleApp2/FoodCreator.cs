using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class FoodCreator
    {
        int mapWight;
        int mapHeight;
        char symb;
        Random random = new Random();
        public FoodCreator(int mapWight, int mapHeight, char symb)
        {
            this.mapWight = mapWight;
            this.mapHeight = mapHeight;
            this.symb = symb;
        }
        public Point CreateFood()
        {
            int x = random.Next(2, mapWight - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, symb);

        }
    }
}
