using System;

namespace Task02
{
    
    class Program
    {
        private static void Print(int[][] arr)
        {

            for (var i = 0; i < arr.Length; i++,Console.WriteLine())
            for (var j = 0; j < arr[i].Length; j++)
                Console.Write(arr[i][j] + " ");
        }
        
        public static int comp2(int[] a, int[] b)
        {
            if (a.Length > b.Length)
                return -1;
            return 1;
        }

        private static int comp(int a, int b)
        {
            if (a > b) return 1;
            if (a < b) return -1;
            return 0;

        }

        static void Main()
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);

            var arr = new int [n][];
            var random = new Random();
            for (var i = 0; i < n; i++)
            {
                arr[i] = new int[random.Next(5, 16)];
            }
            for (var i = 0; i < n; i++)
            for (var j = 0; j < arr[i].Length; j++)
            {
                arr[i][j] = random.Next(-10, 11);
            }
            Print(arr);
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Array.Sort(arr[i], comp);
            }
            Array.Sort(arr,comp2);
            Print(arr);
        }
    }
}