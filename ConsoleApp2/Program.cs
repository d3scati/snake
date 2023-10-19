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
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetBufferSize(120, 30);
            Console.CursorVisible = false;

            //HorizontalLine line = new HorizontalLine(0, 119, 0, '+');
            //VerticalLine line1 = new VerticalLine(0,29, 0, '+');
            //HorizontalLine line2 = new HorizontalLine(0, 119, 29, '+');
            //VerticalLine line3 = new VerticalLine(0, 29, 119, '+');

            Walls walls = new Walls(120, 30);
            walls.Draw();

            Point point = new Point(4,10,'*');
            Figure fSnake = new Snake(point, 4, Direction.DOWN);
            Snake snake = (Snake)fSnake;
            fSnake.Draw();

            //List<Figure> figures = new List<Figure>();
            //figures.Add(line);
            //figures.Add(line1);
            //figures.Add(line2);
            //figures.Add(line3);
            //figures.Add(fSnake);

            //foreach (var f in figures)
            //{
            //    f.Draw();
            //}

            FoodCreator foodCreator = new FoodCreator(120, 30, '$');
            Point food = foodCreator.CreateFood(walls);
            food.Draw();


            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

                Thread.Sleep(45);
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood(walls);
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    int centerX = Console.WindowWidth / 2;
                    int centerY = Console.WindowHeight / 2;

                    string[] messageLines = 
                        {
                            "===========================================",
                            "                ИГРА ОКОНЧЕНА              ",
                            "                                           ",
                            "   Автор : студент каф. ИТиС Селезнев Н.д  ",
                            " В рамках практики Языки Программирования  ",
                            "===========================================",
                        };

                    int messageWidth = messageLines.Max(line => line.Length);
                    int messageHeight = messageLines.Length;

                    for (int i = 0; i < messageLines.Length; i++)
                    {
                        int x = centerX - messageWidth / 2;
                        int y = centerY - messageHeight / 2 + i;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(messageLines[i]);

                    }
                    Console.SetCursorPosition(0, 29);
                    Console.ReadLine();
                    break;
                }

            }
        }

    }
}
