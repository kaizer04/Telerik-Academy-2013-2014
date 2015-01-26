/*Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractsPalindromes
{
    static void Main()
    {
        Console.WriteLine("Extracting all palindromes");
        Console.Write("Enter a text: ");
        string s = Console.ReadLine();
        char[] separators = { ' ', ',', '.', '!', '\n', '\r' };
        string[] text = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        bool palindromes = false;
        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < text[i].Length; j++)
            {
                if (text[i][j] == text[i][text[i].Length - 1 - j])
                {
                    palindromes = true;
                }
                else
                {
                    palindromes = false;
                    break;
                }
                
            }
            if (palindromes)
            {
                Console.WriteLine(text[i]);
            }

        }
 
    }
}