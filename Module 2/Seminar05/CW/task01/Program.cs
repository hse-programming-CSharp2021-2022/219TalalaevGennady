using System;
using System.Reflection.Metadata.Ecma335;

namespace task01
{
    abstract class Animal
    {
        public string name { get; set; }
        public int age { get; set; }

        public abstract string AnimalSound();

        public abstract string AnimalInfo();

    }

    class Dog : Animal
    {
        private string poroda { get; set; }
        private bool IsTrained { get; set; }

        public Dog(string a, bool b)
        {
            poroda = a;
            IsTrained = b;
        }
        public override string AnimalSound()
        {
            return "Gaf";
        }

        public override string AnimalInfo()
        {
            return $"Имя {name} Возвраст: {age} Звук {AnimalSound()} Тренирована: {IsTrained} Порода: {poroda}";
        }
    }

    class Cow : Animal
    {
        private int kol { get; set; }
        public Cow(int a)
        {
            kol = a;
        }
        public override string AnimalSound()
        {
            return "Muuu";
        }

        public override string AnimalInfo()
        {
            return $"Имя {name} Возвраст: {age} Звук {AnimalSound()} Количество молока: {kol}";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Animal tati = new Cow(100);
            Animal tati1 = new Dog("doter", true);
            tati.age = 1;
            tati1.age = 2;
            tati.name = "qqq";
            tati1.name = "gggg";
            Console.WriteLine(tati.AnimalInfo());
            Console.WriteLine(tati1.AnimalInfo());
        }
    }
}