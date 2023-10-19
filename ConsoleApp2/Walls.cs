using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontalLine upline = new HorizontalLine(0, mapWidth - 1, mapHeight-30,'+');
            HorizontalLine downline = new HorizontalLine(0, mapWidth - 1, mapHeight-1, '+');
            VerticalLine leftline = new VerticalLine(0, mapHeight - 1, mapWidth-120, '+');
            VerticalLine rightline = new VerticalLine(0, mapHeight - 1, mapWidth -1, '+');
            VerticalLine obstacle1 = new VerticalLine(mapHeight - 22, mapHeight - 8, mapWidth / 2, '+');
            VerticalLine obstacle2 = new VerticalLine(mapHeight - 25, mapHeight - 5, mapWidth / 2 + 45, '+');
            HorizontalLine obstacle3 = new HorizontalLine(10, 50, 8, '+');
            HorizontalLine obstacle4 = new HorizontalLine(20, 90, 25, '+');
            HorizontalLine obstacle5 = new HorizontalLine(50, 90, 3, '+');

            wallList.Add(obstacle1);
            wallList.Add(obstacle2);
            wallList.Add(obstacle3);
            wallList.Add(obstacle4);
            wallList.Add(obstacle5);
            wallList.Add(upline);
            wallList.Add(downline);
            wallList.Add(leftline);
            wallList.Add(rightline);

        }
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsInsideWalls(Point point)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(point))
                {
                    return true; 
                }
            }
            return false; 
        }

    }
}
