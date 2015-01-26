/*Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ConvertsStringToUnicodeCharacterLiterals
{
    static void Main()
    {
        Console.WriteLine("Converts a string to a sequence of C# Unicode character literals.");
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();
        for (int i = 0; i < s.Length; i++)
        {
            //int charS = s[i];
            Console.Write("\\u{0:x4}", (int) s[i]);
        }

        Console.WriteLine();
    }
}