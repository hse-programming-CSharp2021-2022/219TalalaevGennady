using System;

namespace task05
{
    class Program
    {
        public static bool checker(double a, double b, double c)
        {
            bool otvet;
            otvet = (a + b >= c) ? (a + c >= b) ? (b + c >= a) ? true : false : false : false;
            return otvet;
        }
        static void Main()
        {
            do
            {
                string str1;
                string str2;
                string str3;
                double a, b, c;
                do
                {
                    str1 = Console.ReadLine();
                } while (!double.TryParse(str1, out a));
                
                do
                {
                    str2 = Console.ReadLine();
                } while (!double.TryParse(str2, out b));
                
                do
                {
                    str3 = Console.ReadLine();
                } while (!double.TryParse(str3, out c));

                Console.WriteLine(checker(a,b,c));
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}