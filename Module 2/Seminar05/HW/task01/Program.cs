using System;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var things = new Cindrella.Something[N];
            var choice = new Random();
            for (var i = 0; i < N; i++)
            {
                if (choice.Next(0, 2) == 0)
                    things[i] = new Cindrella.Lentil();
                else
                    things[i] = new Cindrella.Ashes();
            }

            foreach (var v in things)
            {
                Console.WriteLine(v.GetType());
            }

            for (var i = 0; i < N; i++)
            {
                if(things[i] is Cindrella.Lentil) 
                    Console.WriteLine(things[i]);
            }
            for (var i = 0; i < N; i++)
            {
                if(things[i] is Cindrella.Ashes) 
                    Console.WriteLine(things[i]);
            }
        }
    }
}