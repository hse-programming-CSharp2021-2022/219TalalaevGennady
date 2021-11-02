using System;

namespace task02
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            double str10 = 0;
            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] == 'A')
                    str10 += Math.Pow(10,str.Length-i);
                if (str[i] == 'B')
                    str10 += Math.Pow(11,str.Length-i);
                if (str[i] == 'C')
                    str10 += Math.Pow(12,str.Length-i);
                if (str[i] == 'D')
                    str10 += Math.Pow(13,str.Length-i);
                if (str[i] == 'E')
                    str10 += Math.Pow(14,str.Length-i);
                if (str[i] == 'F')
                    str10 += Math.Pow(15, str.Length - i);
                else
                    str10 += Math.Pow((double) str[i], str.Length - i - 1);
            }
            //Console.WriteLine(str10);
            int str11 = (int) str10;
            string strAns = "";
            while (str11 != 0)
            {
                strAns = strAns + (str11 % 2);
                str11 /= 2;
            }
            for(var i = strAns.Length -1; i >= 0; i--)
                Console.Write(strAns[i]);
        }
    }
}