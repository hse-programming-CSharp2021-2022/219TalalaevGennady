using System;

namespace task02
{
    class Program
    {
        public static int umnozhenie(int a, int b, int c)
        {
            return a * b * c;
        }
        static void Main()
        {
            do
            {
                string str;
                int x;
                do
                {
                    str = Console.ReadLine();
                } while (!int.TryParse(str, out x));

                int a, b, c;
                a = x / 100;
                b = x / 10 % 10;
                c = x % 10;
                Console.WriteLine(umnozhenie(a,b,c));
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}