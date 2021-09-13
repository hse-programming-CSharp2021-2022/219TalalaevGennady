using System;
using System.Numerics;

namespace task02
{
    class Program
    {
        public static double GetSquare(double r)
        {
            return Math.PI * r * r;

        }

        public static double GetLenght(double r)
        {
            return 2 * Math.PI * r;
        }
        static void Main()
        {
            double r;
            string str;
            do
            {
                Console.WriteLine("Введите радиус:");
                str = Console.ReadLine();
            } while (!double.TryParse(str, out r));
            str = $"{GetSquare(r):f3} - {GetLenght(r):f3}";
            Console.WriteLine(str);
        }
    }
}