/*Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintIndexOfLettersInArray
{
    static void Main()
    {
        char[] array = new char[26];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (char)(i + 65);
        }
        Console.WriteLine("Enter a word with CAPITAL LETTER:");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (word[i] == array[j])
                {
                    Console.WriteLine("The index of {0} is {1}", word[i], j);
                }
            }
        }
    }
}