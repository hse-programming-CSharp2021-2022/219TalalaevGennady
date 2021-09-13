using System;

namespace task01
{
    class Program
    {
        public static int CalculateBine(uint n)
        {
            double b = (1 + Math.Sqrt(5)) / 2;
            double un = (Math.Pow(b, n) - Math.Pow(-b, -n)) / (2 * b - 1);
            return (int) (un + 0.5);
        }
        static void Main()
        {
            do
            {
                uint n;
                int res;
                string line;
                do
                {
                    line = Console.ReadLine();
                } while (!uint.TryParse(line, out n));
                res = CalculateBine(n);
                Console.WriteLine(res);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}