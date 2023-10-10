using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);
            Console.CursorVisible = false;
            HorizontalLine line = new HorizontalLine(0, 119, 0, '+');
            VerticalLine line1 = new VerticalLine(0,29, 0, '+');
            HorizontalLine line2 = new HorizontalLine(0, 119, 29, '+');
            VerticalLine line3 = new VerticalLine(0, 29, 119, '+');
            line.Drow();
            line1.Drow();
            line2.Drow();
            line3.Drow();
            Point point = new Point(4,4,'*');
            Snake snake = new Snake(point, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();
            Thread.Sleep(2000);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();

            Console.ReadLine();
        }

    }
}
