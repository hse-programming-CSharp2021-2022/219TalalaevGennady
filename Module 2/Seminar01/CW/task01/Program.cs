// каждый класс наследуется от Object
// работаем с нестатическими классами
using System;

namespace task01
{
    class Point2D // iternal // внутри private
    {
        //делаем плохо (публично)
        public int x, y;

        public int X
        {
            get { return x; } //для доступа
            set { x = value; } //для записи
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        
    }
    class Program
    {
        static void Main()
        {
            var point = new Point2D();
            var point2 = new Point2D();
            point2.X = 5;
            point2.X = 10;
            Console.WriteLine(point.X + " " + point.Y);
            Console.WriteLine(point2.X + " " + point2.Y);
        }
    }
}