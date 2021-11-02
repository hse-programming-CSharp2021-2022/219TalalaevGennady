using System;

namespace task02
{
    class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point2D(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        public static void PrintName()
        {
            Console.WriteLine("Point2D");
        }

        public double Distance()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public double Distance(Point2D point)
        {
            return Math.Sqrt((X - point.X) * (X - point.X) + (Y - point.Y) * (Y - point.Y));
        }

        public static Point2D operator +(Point2D p1, Point2D p2)
        {
            return new Point2D(p1.X + p2.X, p1.Y + p2.Y);
        }
        
        public static Point2D operator +(Point2D p1, int a)
        {
            return new Point2D(p1.X + a, p1.Y + a);
        }
        
        public static Point2D operator +(int a, Point2D p1)
        {
            return new Point2D(p1.X + a, p1.Y + a);
        }
        
        public static Point2D operator -(Point2D p1, Point2D p2)
        {
            return new Point2D(p1.X - p2.X, p1.Y - p2.Y);
        }

        public override string ToString()
        {
            return X + " " + Y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var point1 = new Point2D(5, 10);
            var point2 = new Point2D(20, 30);
            Point2D.PrintName();
            Console.WriteLine(point1.Distance());
            Console.WriteLine(point2.Distance());
            Console.WriteLine(point1.Distance(point2));
            Console.WriteLine(point1.X + " " + point1.Y);
            Console.WriteLine(point2.X + " " + point2.Y);
            Console.WriteLine(point1 + 5);
        }
    }
}