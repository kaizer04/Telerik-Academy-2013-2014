/*Write a program that extracts from a given text all sentences containing given word.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractsSentences
{
    static void Main()
    {
        Console.WriteLine("Extracts from a given text all sentences containing given word.");
        Console.Write("Enter text: ");
        string s = Console.ReadLine();
        Console.Write("Enter a word: ");
        string sub = Console.ReadLine();
        string[] sentences = s.Split(new char[]{'.'}, StringSplitOptions.RemoveEmptyEntries);

        foreach (string sentence in sentences)
        { 
            string checkingSentence = sentence.ToLower();
            int index = checkingSentence.IndexOf(sub.ToLower() + " ");

            if (index > -1)
            {
                Console.Write(sentence.Trim());
                Console.WriteLine(".");
            }
        }
    




        //string subS = " " + sub + " ";
        ////string subS = "";
        //StringBuilder replace = new StringBuilder(s);
        //int findDot1 = 0;
        //int findLenght = 0;
        //for (int i = 0; i < s.Length; i++)
        //{
        //    int findSubS = s.IndexOf(subS, i);
        //    int findDot2 = s.IndexOf(".", i) - findLenght;
            
        //    if (findSubS != -1 && ((findSubS - findLenght) < findDot2))
        //    {
        //        replace = replace.Remove(findDot1 - findLenght, (findDot2 - findDot1 + findLenght + 1));
        //        findLenght += findDot2 - findDot1 + 1;
        //    }
                        
        //    findDot1 = findDot2 + 1;
        //    //    int find2 = s.IndexOf("</upcase>", i);
        //    //subS = s.Substring(find1 + 8, find2 - (find1 + 8));
        //    //Console.WriteLine(subS);
        //    //replace = replace.Replace("<upcase>" + subS + "</upcase>", subS.ToUpper());
        //    i = findDot2 + 1;
        //}
        //Console.WriteLine(replace);
    }
}