using System;

namespace task01
{

    class ArifmeticProgression
    {
        //не хранит данные
        public int A0 { get; private set; }
        public int D { get; private set; }

        public static int count = 0;
        public static int count2;

        static ArifmeticProgression()
        {
            Console.WriteLine("static construct");
        }
        public ArifmeticProgression(int a0, int d)
        {
            A0 = a0;
            D = d;
            count++;
        }
        public ArifmeticProgression() :this(0,0) {}
        //индексатор
        public  double this[int index]
        {
            get
            {
                return A0 + D * index;
            }
            private set
            {
                
            }
        }
        // destructor 
        //только один
        // нельзя вызывать
        
        ~ArifmeticProgression()
        {
            Console.WriteLine("Destroy object");
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            var progression = new ArifmeticProgression(2, 10);
            Console.WriteLine(progression[3]);
            Console.WriteLine(progression[5]);
            new ArifmeticProgression(2, 10);
            new ArifmeticProgression(2, 10);
            new ArifmeticProgression(2, 10);
            Console.WriteLine(ArifmeticProgression.count);
        }
    }
}