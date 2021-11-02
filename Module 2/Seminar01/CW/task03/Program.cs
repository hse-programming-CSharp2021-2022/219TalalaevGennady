using System;

namespace task03
{
    class RegularPolygon
    {
        public int n { get; set; }
        public int r { get; set; }
        public RegularPolygon(int x = 0, int y = 0)
        {
            n = x;
            r = y;
        }
        
        public double Perimetr()
        {
            return 2 * r * Math.Tan(Math.PI / 2 / n);
        }

        public double Square()
        {
            return n *  r * r * Math.Tan(Math.PI / 2 / n);
        }

        public override string ToString()
        {
            return ("Периметр: " + Perimetr() + " Площадь" + Square()).ToString();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var k = int.Parse(Console.ReadLine());
            var tati = new RegularPolygon[k];
            
                for (var i = 0; i < k; i++)
                {
                    //Console.WriteLine(k + " qqtati " + i);
                    var count = int.Parse(Console.ReadLine());
                    var radius = int.Parse(Console.ReadLine());
                    tati[i] = new RegularPolygon(count, radius);
                    Console.WriteLine("Количество сторон: " + tati[i].n + " Радиус многоугольника: " + tati[i].r);
                } 
               

            var min = Double.MaxValue;
            var max = -1.0;
            for (var i = 0; i < k; i++)
            {
                if (min > tati[i].Square())
                    min = tati[i].Square();
                if (max < tati[i].Square())
                    max = tati[i].Square();
            }
            for (var i = 0; i < k; i++)
            {
                if(tati[i].Square() == min)
                    Console.ForegroundColor = ConsoleColor.Green;
                if(tati[i].Square() == max)
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Площадь: " + tati[i].Square() + " ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Периметр: " + tati[i].Perimetr() + " ");
                Console.WriteLine();
            }
            


        }
    }
}