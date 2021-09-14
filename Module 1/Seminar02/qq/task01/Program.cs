using System;

namespace task01
{
    class Program
    {
        public static void function1()
        {
            for (int i = 1; i < 11; i++) Console.WriteLine(i*i);
        }

        public static void function2()
        {
            int i = 1;
            while (i < 11)
            {
                Console.WriteLine(i*i);
                i++;
            }
        }

        public static void function3()
        {
            int i = 1;
            do
            {
                
                Console.WriteLine(i * i);
                i++;
            } while (i < 11);
        }
        
        
        static void Main()
        {
           function1();
           function2();
           function3();
        }
    }
}