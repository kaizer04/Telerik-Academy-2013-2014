/*Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountLetter
{
    static void Main()
    {
        {
            Console.Write("Enter a text: ");
            
            string text = Console.ReadLine();

            char[] letters = new char[65536];

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    letters[text[i]]++;
                }
            }

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] > 0 && char.IsLetter((char)i))
                {
                    Console.WriteLine("{0} is {1} times", (char)i, (int)letters[i]);
                }
            }

        }
    }
}