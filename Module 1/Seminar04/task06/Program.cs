using System;

namespace task06
{
    class Program
    {
        public static ulong Factorial(ulong step)
        {
            ulong proisv = 1;
            for (ulong i = 1; i <= (step * 2); i++)
                proisv *= i;
            return proisv;

        }
        
        public static ulong Factorial1(ulong step)
        {
            ulong proisv = 1;
            for (ulong i = 1; i <= (step); i++)
                proisv *= i;
            return proisv;

        }
        public static double Method1(double x)
        { 
            double sumnov = Math.Pow(x,2);
            double sumstar = 0;
            ulong step = 1;
            while (sumnov != Double.PositiveInfinity && sumnov != Double.NaN)
            {
                step++;
                sumstar = sumnov;
                sumnov += Math.Pow(-1, step - 1) * Math.Pow(2, 2 * step - 1) * Math.Pow(x, 2 * step) / Factorial(step);
            }
            return  sumstar;
        }

        public static double Method2(double x)
        {
            double sumnov = 1;
            ulong step = 1;
            double sumstar = 0;
            while (sumnov != Double.PositiveInfinity && sumnov != Double.NaN)
            {
                sumstar = sumnov;
                step++;
                sumnov += Math.Pow(x, step) / Factorial1(step);
            }

            return sumstar;

        }
        
        static void Main()
        {
            do
            {
                double x;
                string str;
                do
                {
                    str = Console.ReadLine();
                } while (!double.TryParse(str, out x));

                Console.WriteLine(Method1(x));
                Console.WriteLine(Method2(x));
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}