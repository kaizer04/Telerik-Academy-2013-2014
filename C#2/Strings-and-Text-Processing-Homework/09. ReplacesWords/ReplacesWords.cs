/*We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReplacesWords
{
    static void ReplaceWord()
    {
 
    }

    //static string SplitWords(string words)
    //{
    //    string[] arrayWords = words.Split(',');
    //    for (int i = 0; i < arrayWords.Length; i++)
    //    { 
    //        arrayWords[i].ToString().ToLower();
    //    }
        
    //}

    static void Main()
    {
        Console.WriteLine("Replaces the forbidden words with asterisks.");
        Console.Write("Enter text: ");
        string s = Console.ReadLine();
        Console.Write("Enter a list of words: ");
        string words = Console.ReadLine();
        //string word = SplitWords(words);
        string[] arrayWords = words.Split(',');
        StringBuilder text = new StringBuilder(s);
        StringBuilder asterisks = new StringBuilder();
        for (int i = 0; i < arrayWords.Length; i++)
        {
            arrayWords[i] = arrayWords[i].Trim();
            for (int j = 0; j < arrayWords[i].Length; j++)
            {
                asterisks.Append('*');
            }
            text = text.Replace(arrayWords[i], asterisks.ToString());
            asterisks.Clear();
        }
        Console.WriteLine(text);
        //for (int i = 0; i < arrayWords.Length; i++)
        //{
        //    Console.WriteLine(arrayWords[i]);
        //}
    }
}