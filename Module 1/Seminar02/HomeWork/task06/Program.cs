using System;

namespace task06
{
    class Program
    {
        public static decimal ans(decimal a, int persent)
        {
            return a / 100 * persent;

        }
        static void Main()
        {
            do
            {
                string str;
                decimal a;

                do
                {
                    str = Console.ReadLine();
                } while (!decimal.TryParse(str, out a));

                string str1;
                int persent;
                do
                {
                    str1 = Console.ReadLine();
                } while (!int.TryParse(str1, out persent));
                
                Console.WriteLine($"Количество денег выделенных на игры: {ans(a,persent):C1}");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}