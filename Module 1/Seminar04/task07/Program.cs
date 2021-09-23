using System;
using System.Xml;

namespace task07
{
    class Program
    {
        public static void Method (ulong a, ulong b, out ulong nod, out ulong nok)
        {
            ulong a1 = a, b1 = b;
            while (a != b)
            {
                if (a > b) a = a - b;
                else b =  b - a;
            }

            nod = a;
            nok = a1 * b1 / nod;
        }
        
        static void Main()
        {
            do
            {
                string str,str1;
                ulong a, b;
                do
                {
                    str = Console.ReadLine();
                } while (!ulong.TryParse(str, out a));
                
                do
                {
                    str1 = Console.ReadLine();
                } while (!ulong.TryParse(str1, out b));
                ulong nod = 0, nok = 0;
                Method(a, b, out nod, out nok);
                Console.WriteLine(nod);
                Console.WriteLine(nok);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}