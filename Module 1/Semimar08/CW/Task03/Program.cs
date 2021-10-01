using System;

namespace Task03
{
    class Program
    {
        static void Main()
        {
            int n, m;

            int.TryParse(Console.ReadLine(), out n);
            int.TryParse(Console.ReadLine(), out m);

            var arr = new int [n, m];
            var k = 1;
            var flag = false;
            for(var i = 0; i < n; i++)
                if (flag == false)
                {


                    for (var j = 0; j < m; j++)
                    {
                        arr[i, j] = k;
                        flag = true;
                        k++;
                    }
                }

                else
                {
                    for (var j = m - 1; j >= 0; j--)
                    {
                        arr[i, j] = k;
                        flag = false;
                        k++;
                    }
                }

            for(var i = 0; i < n; i++,Console.WriteLine())
            for (var j = 0; j < m; j++)
                Console.Write(arr[i,j]+ " ");
        }
    }
}