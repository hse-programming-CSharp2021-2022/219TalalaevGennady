using System;

class A
{
    static void foo() { Console.WriteLine("foo"); }

    static int foo() { return 5; }

    static private bool less(int a, int b) { 							return a < b; }
        
    static public bool less(long c, long d) { 							   return c + d < 100; }
}
    
class Program
{        
    static void Main(string[] args)
    {
        A.foo();
        Console.WriteLine(A.less(10l, 15l));
    }
}
