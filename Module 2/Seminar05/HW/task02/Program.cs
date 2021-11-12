using System;

namespace task02
{
    class Shape
    {
        public virtual double Area()
        {
            return 0;
        }
        
    }

    class Circle : Shape
    {
        private double R { get; set; }

        public Circle(double r)
        {
            R = r;
        }
        public override double Area()
        {
            return 2 * Math.PI * R;
        }

        public override string ToString()
        {
            return " Площадь: " + this.Area();
        }
    }

    class Cylinder : Shape
    {
        private double R { get; set; }
        private double H { get; set; }
        public Cylinder(double r, double h)
        {
            R = r;
            H = h;
        }
        public override double Area()
        {
            return Math.PI * R * R * 2 + 2 * Math.PI * R * H;
        }

        public override string ToString()
        {
            return " Площадь " + this.Area();
        }
    }

    class Sphere : Shape
    {
        private double R { get; set; }
        public Sphere(double r)
        {
            R = r;
        }

        public override double Area()
        {
            return 4 * R * Math.PI * R;
        }
        public override string ToString()
        {
            return " Площадь: " + this.Area();
        }
    }
    class Program
    {
        /*
        public int Comp(Shape a, Shape b)
        {
            if (a is Sphere && b is Cylinder)
                return 1;
            if (a is Sphere && b is Circle)
                return 1;
            if (a is Cylinder && b is Circle)
                return 1;
            if (a is Sphere && b is Sphere)
                return 0;
            if (a is Cylinder && b is Cylinder)
                return 0;
            if (a is Circle && b is Circle)
                return 0;
            return -1;
        } */
        static void Main(string[] args)
        {
            var r = new Random();
            var n1 = r.Next(3, 6);
            var n2 = r.Next(3, 6);
            var n3 = r.Next(3, 6);
            var arr = new Shape[n1 + n2 + n3];
            for (var i = 0; i < n1; i++)
            {
                arr[i] = new Circle(r.Next(10));
            }
            for (var i = n1; i < n1 + n2; i++)
            {
                arr[i] = new Cylinder(r.Next(10), r.Next(10));
            }
            for (var i = n1 + n2; i < n1 + n2 +n3; i++)
            {
                arr[i] = new Sphere(r.Next(10));
            }

            foreach (var v in arr)
            {
                if(v is Circle)
                    Console.Write("Круг");
                if(v is Sphere)
                    Console.Write("Шар");
                if(v is Cylinder)
                    Console.Write("Цилиндр");
                Console.Write(v);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}