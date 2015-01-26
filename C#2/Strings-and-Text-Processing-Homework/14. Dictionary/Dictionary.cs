/*A dictionary is stored as a sequence of text lines containing words and their explanations. Write a program that enters a word and translates it by using the dictionary.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Dictionary
{
    static void Main()
    {
        //речникът представям като масив от sring.Като всеки string съдържа думата която търсим и нейното значение
        string[] dictionary = {
            ".NET - platform for applications from Microsoft",
            "CLR - managed execution environment for .NET",
            "namespace - hierarchical - organization of classes"
        };
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        
        //if (dictionary.Contains(word))
        //{
        //    Console.WriteLine(dictionary[word]);
        //}
        int indexWord = -1;
        for (int i = 0; i < dictionary.Length; i++)
        {
            indexWord = dictionary[i].IndexOf(word, 0);
            if (indexWord == 0)
            {
                Console.WriteLine(dictionary[i]);
                break;
            }
        }
        if (indexWord == -1)
        {
            Console.WriteLine("No information for this word!");
        }
    }
}