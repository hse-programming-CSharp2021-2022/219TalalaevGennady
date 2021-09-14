using System;

namespace task01
{
    class Program
    {
        public static int Power2(int x)
        {
            return x * x;
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
                
                Console.WriteLine(12 * Power2(x) * Power2(x) + 9 * Power2(x) * x - 3 * Power2(x) + 2 * x - 4);
                
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}