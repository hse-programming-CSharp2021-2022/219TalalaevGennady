using System;

namespace task6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("F: 5.0 / 3.0 = " + (5.0 / 3.0).ToString("F"));
            Console.WriteLine("F4: 5.0 / 3.0 = " + (5.0 / 3.0).ToString("F4"));
            Console.WriteLine("E: 5.0 / 3.0 = " + (5.0 / 3.0).ToString("E"));
            Console.WriteLine("E5: 5.0 / 3.0 = " + (5.0 / 3.0).ToString("E5"));
            Console.WriteLine("G: 5.0 / 3.0 = " + (5.0 / 3.0).ToString("G"));
            Console.WriteLine("G3: 5.0 / 3.0 = " + (5.0 / 3.0).ToString("G3"));
            Console.WriteLine("G3: 5.0 / 3e10 = " + (5.0 / 3e10).ToString("G3"));
            Console.WriteLine("G: 5.0 / 3e-10 = " + (5.0 / 3e-10).ToString("G"));
            Console.WriteLine("F: 5.0 / 3e20 = " + (5.0 / 3e20).ToString("F"));
        }
    }
}