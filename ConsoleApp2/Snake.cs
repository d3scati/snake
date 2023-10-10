using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Snake:Figure
    {
        //public Snake(Point tail, int length, Direction direction)
        //{
        //    pList = new List<Point>();
        //    for (int i = 0; i < length; i++)
        //    {
        //        Point point = new Point(tail); // создаем копии хвостовой точки
        //        point.Move(i, direction); // сдвиг точки на i позиций по направлению direction
        //        pList.Add(point);// добавление точки в список
        //    }

        //}
        Direction direction; // для определения направления движения
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();     // создание списка точек
            for (int i = 0; i < length; i++)
            {
                Point point = new Point(tail); // создаем копии хвостовой точки
                point.Move(i, direction);      // сдвиг точки на i позиций по направлению
                                           // direction
                pList.Add(point);              // добавление точек в список
            }
        }

        internal void Move()
        {
            Point tail = pList.First(); // метод First возвращает первый элемент списка
            pList.Remove(tail);         // удаляем хвост (последнюю точку)
            Point head = GetNextPoint();
            pList.Add(head);
            tail.Clear();               // на экране затираем хвостовую точку
            head.Draw();
        }
        public Point GetNextPoint()     // дает следующую точку для головы
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction); // сдвиг точки по направлению direction
            return nextPoint;
        }
    }

}
