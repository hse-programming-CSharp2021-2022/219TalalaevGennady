using System;

namespace task9
{
    class Program
    {
        static void Main()
        {
           string s = Console.ReadLine();
           double a = Double.Parse(s);
           string ss = Console.ReadLine();
           double b = Double.Parse(ss);

           int aa = (int) a;
           int  bb =  (int) b;
           Console.WriteLine(a+b - aa -bb);
           
        }
    }
}