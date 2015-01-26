/*Write a program to check if in a given expression the brackets are put correctly.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckBracketsCorrectly
{
    static void Main()
    {
        Console.Write("Enter an expression: ");
        string s = Console.ReadLine();
        int brackets = 0; 
        
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                brackets++;
            }
            if (s[i] == ')')
            {
                brackets--;
            }
            if (brackets < 0)
            {
                Console.WriteLine("The brackets ARE NOT put correctly.");
                break;
            }
        }
        if (brackets == 0)
        {
            Console.WriteLine("The brackets ARE put correctly.");
        }
        else
        {
            Console.WriteLine("The brackets ARE NOT put correctly.");
        }
    }
}