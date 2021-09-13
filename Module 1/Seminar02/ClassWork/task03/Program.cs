using System;

namespace task03
{
    class Program
    {
        static void Main()
        {
            int a = 10;
            int b = 50;
            int res = 0;
            // тернарная операция 
            res = (a > b) ? (a + b) : (a * b);
            /*if (a > b)
            {
                res = a + b;
            }
            else
            {
                res = a * b;
            } */
            Console.WriteLine(res);
        }
    }
}