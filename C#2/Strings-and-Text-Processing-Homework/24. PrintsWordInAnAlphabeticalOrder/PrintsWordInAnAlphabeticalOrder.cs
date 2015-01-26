/*Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintsWordInAnAlphabeticalOrder
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] words = text.Split();
        var ordered = words.OrderBy(x => x);
        foreach (var item in ordered)
        {
            Console.WriteLine(item);
        }
    }
}