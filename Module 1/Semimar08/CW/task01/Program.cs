using System;

namespace task01
{
    class Program
    {
        private static int Odd(int a, int b) 
        {
            if (a % 2 == 0 && b % 2 == 0) return 0;
            if (a % 2 == 0 && b % 2 != 0) return -1;
            return 1;

        }

        private static int LenghtNumber(int a, int b)
        {
            int k = 0, k1 = 0;

            while (a != 0)
            {
                a /= 10;
                k++;
            }

            while (b != 0)
            {
                b /= 10;
                k1++;
            }

            if (k > k1) return 1;
            if (k == k1) return 0;
            return -1;

        }

        private static int Summ(int a, int b)
        {
            int k = 0, k1 = 0;
            while (a != 0)
            {
                k += a % 10;
                a /= 10;
                
            }

            while (b != 0)
            {
                k1 += b % 10;
                b /= 10;
                
            }
            if (k > k1) return 1;
            if (k == k1) return 0;
            return -1;
        }
        

        private static void Output(int [] arr)
        {
            Console.WriteLine();
            foreach (var value in arr)
            {
                Console.Write(value + " ");
            }
        }
        
        
        static void Main()
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            var arr = new int [n];
            var random = new Random();
            for (var i = 0; i < n; i++)
            {
                arr[i] = random.Next(0, 1001);
            }
            Array.Sort(arr);
            Output(arr);
            Array.Sort(arr, Odd);
            Output(arr);
            Array.Sort(arr, LenghtNumber);
            Output(arr);
            Array.Sort(arr,Summ);
            Output(arr);

        }
    }
}