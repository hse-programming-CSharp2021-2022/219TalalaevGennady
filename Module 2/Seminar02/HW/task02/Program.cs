using System;

namespace task02
{
    class ConsolePlate
    {
        private char _plateChar;
        private ConsoleColor _plateColor;
        private ConsoleColor _backgroundColor;
        
        public ConsolePlate()
        {
            _plateChar = 'A';
            _plateColor = default;
            _backgroundColor = default;
        }

        public ConsolePlate(char @char, ConsoleColor color, ConsoleColor backcolor)
        {
            _plateChar = @char;
            _plateColor = color;
            _backgroundColor = backcolor;
        }

        public char @char
        {
            set
            {
                if (value < 'A' || value > 'Z') _plateChar = 'A';
                else _plateChar = value;
            }
            get { return _plateChar; }
        }

        public ConsoleColor color
        {
            set
            {
                _plateColor = value;
            }
            get
            {
                return _plateColor;
            }
        }

        public ConsoleColor backcolor
        {
            set
            {
                if (_plateColor == value)
                    _backgroundColor = (ConsoleColor) (((int) value + 1) % 16);
                else
                    _backgroundColor = value;
            }
            get { return _backgroundColor; }
        }

        public override string ToString()
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = backcolor;
            return @char.ToString();
        }
    }
    class Program
    {
        static void Main()
        {
            var o = new ConsolePlate('O', ConsoleColor.White, ConsoleColor.DarkMagenta);
            var x = new ConsolePlate('X', ConsoleColor.White, ConsoleColor.Red);
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++, Console.WriteLine())
                for(var j = 0; j < n; j++)
                    if ((i + j) % 2 == 0)
                        Console.Write(x);
                    else 
                        Console.Write(o);
            Console.BackgroundColor = default;
            Console.ForegroundColor = default;
        }
    }
}