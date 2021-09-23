using System;

namespace task02
{
    class Program
    {
        public static bool Shift(ref char ch)
        {
            if (ch == '-') return false;
            else
            {
                
                int tati1 = ch + 4;
                //   Console.WriteLine(tati1);
                int tati2 = tati1 % 'z';
                //  Console.WriteLine(tati2);
                // int tati3 = tati2 + (int)'a';
                // Console.WriteLine(tati3);
                if (tati2 <= 4) tati2 = 'a' + tati2 - 1;
                ch = (char) tati2;
                Console.WriteLine(ch); 
                return true;
            }
           
        }
        static void Main()
        {
            Console.WriteLine("Введите букву алфавита");
            do
            {
                bool otv;
                
                char ch;
                string str;
                str = Console.ReadLine();
                if (str.Length == 1 && str[0] >= 'a' && str[0] <= 'z')
                {
                    ch = str[0];
                    otv  = Shift(ref ch);
                }
                else
                {
                    ch = '-';
                   otv = Shift(ref ch);
                }
                
                Console.WriteLine(otv);
                Console.WriteLine("Для выхода нажмите Escape");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}