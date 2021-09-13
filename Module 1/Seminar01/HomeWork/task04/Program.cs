using System;

namespace task04
{
    class Program
    {
        static void Main(string[] args)
        {
            string  s = Console.ReadLine();
            string ss = Console.ReadLine();
            double U = double.Parse(s);
            double R = double.Parse(ss);
            Console.WriteLine(U / R);
            Console.WriteLine((U*U)/R);
        }
    }
}