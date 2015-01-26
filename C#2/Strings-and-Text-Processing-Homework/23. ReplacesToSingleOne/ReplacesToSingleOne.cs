/*Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReplacesToSingleOne
{
    
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";

        StringBuilder answer = new StringBuilder();
        answer.Append(text[0]);

        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] != text[i-1])
            {
                answer.Append(text[i]);
            }
        }
        Console.WriteLine(answer.ToString());
    }
}