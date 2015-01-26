/*Write a program that reads a string, reverses it and prints the result at the console.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReversesString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();
        char[] revS = s.ToCharArray();
        Array.Reverse(revS);
        
        //string printS = new string(revS);
        Console.Write("Reversed string: ");
        Console.WriteLine(revS);
    }
}