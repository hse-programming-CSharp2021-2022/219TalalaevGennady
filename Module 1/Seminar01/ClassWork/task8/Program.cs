using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt, secondInt;
            Console.Write("Целое число: ");
            string InputStr = Console.ReadLine();
            firstInt = int.Parse(InputStr);
            
            Console.Write("Целое число: ");
            InputStr = Console.ReadLine();
            int.TryParse(InputStr, out secondInt);
            
            Console.WriteLine("Ваш текст: " + (firstInt - secondInt));
            Console.WriteLine("Ваш текст: " + (firstInt * secondInt));
            Console.WriteLine("Ваш текст: " + (firstInt / secondInt));
            Console.WriteLine("Ваш текст: " + (firstInt % secondInt));
            Console.WriteLine("Ваш текст: " + (firstInt << secondInt));
            Console.WriteLine("Ваш текст: " + (firstInt >> secondInt));
            
        }
    }
}