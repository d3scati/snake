using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class FoodCreator:Figure
    {
        int mapWidth;
        int mapHeight;
        char symb;
        Random random = new Random();
        public FoodCreator(int mapWidth, int mapHeight, char symb)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.symb = symb;
        }
        public Point CreateFood(Walls walls)
        {
            while (true)
            {
                int x = random.Next(0, mapWidth);
                int y = random.Next(0, mapHeight);

                // Проверяем, не находится ли новая точка для еды внутри стен
                if (!walls.IsInsideWalls(new Point(x, y,symb)))
                {
                    return new Point(x, y, symb);
                }
            }
        }
    }
}
