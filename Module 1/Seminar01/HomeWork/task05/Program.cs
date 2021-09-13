using System;

namespace task05
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string ss = Console.ReadLine();
            double a = Double.Parse(s);
            double b = Double.Parse(ss);
            Console.WriteLine(Math.Sqrt(a * a + b * b));
        }
    }
}