﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Point
    {
        public int x;
        public int y;
        public char symb;
        public Point()
        {

        }
        public Point(int x, int y, char symb)
        {
            this.x = x;
            this.y = y;
            this.symb = symb;
        }
        public Point(Point point)
        {
            x = point.x;
            y = point.y;
            symb = point.symb;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x,y);
            Console.Write(symb);
        }
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            { x = x + offset; }
            else if (direction == Direction.LEFT)
            { x = x - offset; }
            else if (direction == Direction.UP)
            { y = y + offset; }
            else if (direction == Direction.DOWN)
            { y = y - offset; }
        }
        public void Clear()
        {
            symb = ' ';
            Draw();
        }

    }

}
