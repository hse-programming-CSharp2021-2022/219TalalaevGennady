using System;

namespace task03
{
    class Program
    {
        public static double discriminant(double a, double b, double c)
        {
            return Math.Sqrt(b * b - 4 * a * c);
        }
        static void Main()
        {
            do
            {
                string str1, str2, str3;
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
              
              double.TryParse(str1, out a);
              double.TryParse(str2, out b);
              double.TryParse(str3, out c);  
              Console.WriteLine("x1 = " + ((-1 * b + discriminant(a,b,c)) / (2 * a)) );
                Console.WriteLine("x2 = " + ((-1 * b - discriminant(a,b,c)) / (2 * a)) );
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}