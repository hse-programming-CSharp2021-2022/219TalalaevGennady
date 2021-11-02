using System;
using System.Runtime.CompilerServices;

namespace task02
{
    class Point
    {
        public double X { set; get; }
        public double Y { set; get; }
        
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Function()
        {
            if ((X > 0) && (Y >= 0))
                return Math.Atan(Y / X);
            if ((X > 0) && (Y < 0))
                return Math.Atan(Y / X) + 2 * Math.PI;
            if (X < 0)
                return Math.Atan(Y / X) + Math.PI;
            if ((X == 0) && (Y > 0))
                return Math.PI / 2;
            if ((X == 0) && (Y < 0))
                return 3 * Math.PI / 2;
            return 0;
        }

        public double R
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);   
            }
        }

    }
    class Program
    {
        private static int Comp(Point x, Point y)
        {
            if (x.R > y.R) return 1;
            if (x.R < y.R) return -1;
            return 0;
        }
        static void Main()
        {
            var a = new Point(1, 3);
            var b = new Point(3, 10);
            var c = new Point(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            var arr = new Point[3];
            arr[0] = a;
            arr[1] = b;
            arr[2] = c;
            Array.Sort(arr, Comp);
            foreach (var tati in arr)
            {
                Console.WriteLine(tati.X + " " + tati.Y + " " + tati.Function() + " " + tati.R); 
            }
        }
    }
}