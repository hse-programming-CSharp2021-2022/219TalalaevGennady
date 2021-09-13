using System;

namespace Seminar1
{
    class Program
    {
        static void Main()
        {
           Console.Write("Введите текст: ");
           string s = Console.ReadLine();
           Console.WriteLine("Ваш текст: " + s);
           Console.WriteLine("Ваш текст: {0}", s);
           Console.WriteLine($"Ваш текст: {s}");
        }
    }
}