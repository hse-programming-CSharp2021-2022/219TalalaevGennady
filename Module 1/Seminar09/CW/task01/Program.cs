using System;
using System.Text;

internal class task01
{
    private static void Main()
    {
        var input = Console.ReadLine();
        string[] vowels = {"e", "E", "y", "Y", "u", "U", "i", "I", "o", "O", "a", "A"};
        var strings = input?.Split(';');
        for (var i = 0; i < strings?.Length; i++)
        {
            var stringNow = strings[i].Split(' ');
            var ansString = new StringBuilder("", 256);
            for (var j = 0; j < stringNow.Length; j++)
                for (var k = 0; k < stringNow[j].Length; k++)
                {
                    ansString.Append(stringNow[j][k]);
                    if (string.Join(' ', vowels).Contains(stringNow[j][k])) 
                        break;
                }
            Console.WriteLine(ansString.ToString());
        }
    }
}