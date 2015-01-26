/*Write a program that reverses the words in given sentence.
	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReversesWords
{
    static void Main()
    {
        Console.WriteLine("Reverses the words in given sentence.");
        Console.Write("Enter a sentence: ");
        string s = Console.ReadLine();
        string[] array = s.Split(new char[] { ' ', ',', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);
        string[] signs = s.Split(array, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(array);
        StringBuilder strBuild = new StringBuilder();
        for (int i = 0; i < array.Length; i++)
        {
            strBuild.Append(array[i] + signs[i]);
        }

        strBuild.ToString();
        Console.WriteLine(strBuild);
    }
}