using System;

namespace task04
{
    class Program
    {
        public static int mod10(int a)
        {
            return a % 10;
        }
        public static int div10(int a)
        {
            return a / 10;
        }
        static void Main()
        {
            do
            {
                string str;
                int a;

                do
                {
                    str = Console.ReadLine();
                } while (!int.TryParse(str, out a));

                int answer = 0;
                answer += mod10(a) * 1000;
                a = div10(a);
                answer += mod10(a) * 100;
                a = div10(a);
                answer += mod10(a) * 10;
                a = div10(a);
                answer += a;
                Console.WriteLine(answer);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}