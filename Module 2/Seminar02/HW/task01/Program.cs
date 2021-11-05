using System;

namespace task01
{
    class MyComplex    {

        private double re
        {
            get;
            set;
        }

        private double im
        {
            get;
            set;
        }
        public MyComplex(double xre, double xim)
        { re = xre; im = xim; }
        
        public static MyComplex operator --(MyComplex mc)
        { return new MyComplex(mc.re-1, mc.im-1); }
        public double Mod() { return Math.Abs(re*re+im*im); }
        
        public static bool operator true(MyComplex f)  {
            if (f.Mod() > 1.0) return true;
            return false;
        }
        public static bool operator false(MyComplex f)  {
            if (f.Mod() <= 1.0) return true;
            return false;
        }

        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re + b.re, a.im + b.im);
        }
        
        public static MyComplex operator -(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re - b.re, a.im - b.im);
        }
        
        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re * b.re - a.im * b.im, a.im * b.re + a.re * b.im);
        }
        
        public static MyComplex operator /(MyComplex a, MyComplex b)
        {
            return new MyComplex((a.re * b.re + a.im * b.im) / (b.re * b.re + b.im * b.im), (a.im * b.re - a.re * b.im) /(b.re * b.re + b.im * b.im));        
        }

        public static string Print(MyComplex a)
        {
            return a.re + " " + a.im;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = new MyComplex(1, 10);
            var b = new MyComplex(2, 33);
            Console.WriteLine(MyComplex.Print(a + b));
            Console.WriteLine(MyComplex.Print(a - b));
            Console.WriteLine(MyComplex.Print(a * b));
            Console.WriteLine(MyComplex.Print(a / b));

        }
    }
}