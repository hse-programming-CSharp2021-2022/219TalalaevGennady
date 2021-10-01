using System;

namespace Task04
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
            var i = 0;
            var j = 0;
            n--;
            m--;
            var difference = 0;
            var difference1 = 0;
            while (k != m * n)
            {
                while (i != n - difference)
                {
                    arr[i, j] = k;
                    k++;
                    if (i == n - difference) break;
                    i++;
                }

                while (j != m - difference1)
                {
                    arr[i, j] = k;
                    k++;
                    if (j == m - difference) break;
                    j++;
                }

                difference++;
                while (i != 0 + difference)
                {
                    arr[i, j] = k;
                    k++;
                    if (i == 0 + difference) break;
                    i--;
                }

                difference1++;
                while (j != 0 + difference1)
                {
                    arr[i, j] = k;
                    k++;
                    if (j == 0 + difference) break;
                    j--;
                }
                //difference++;
              //  difference1++;

            }
        }
    }
}