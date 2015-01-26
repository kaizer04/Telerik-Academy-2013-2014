/*Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FilledString
{
    static void Main()
    {
        Console.WriteLine("If the length of the string is less than 20, the rest of the characters should be filled with '*'");
        Console.Write("Enter string: ");
        string s = Console.ReadLine();
        //string subS = "";
        StringBuilder fillS = new StringBuilder(s);
        for (int i = s.Length; i <= 19; i++)
        {
            fillS.Append('*');
        }
        Console.WriteLine(fillS);
    }
}