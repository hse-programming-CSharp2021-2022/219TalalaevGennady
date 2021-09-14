using System;

namespace task07
{
    class Program
    {
        public static string ans1(double a)
        {
            string m1;
            int b;
            double c;

            b = (int) a;
            c = a - b;
            m1 = "Целая часть: " + b + " Дробная часть: " + c;
            return m1;

        }

        public static string ans2(double a)
        {
            string m2;
            double q = Math.Pow(a, 2);
            double kor = Math.Sqrt(a);
            m2 = "Квадрат числа: " + q + " Корень числа: " + kor;
            return m2;
        }
        
        static void Main(string[] args)
        {
            do
            {
                double a;
                string str;

                do
                {
                    str = Console.ReadLine();
                } while (!double.TryParse(str, out a));

                Console.WriteLine(ans1(a));
                Console.WriteLine(ans2(a));

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}