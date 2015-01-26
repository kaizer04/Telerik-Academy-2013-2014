/*You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ChangesText
{
    static void Main()
    {
        Console.WriteLine("Changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase.");
        Console.WriteLine("Enter text: ");
        string s = Console.ReadLine();
        string subS = "";
        StringBuilder replace = new StringBuilder(s);
        for (int i = 0; i < s.Length - 9; i++)
        {
            int find1 = s.IndexOf("<upcase>", i);
            int find2 = s.IndexOf("</upcase>", i);
            subS = s.Substring(find1 + 8, find2 - (find1 + 8));
            //Console.WriteLine(subS);
            replace = replace.Replace("<upcase>" + subS + "</upcase>", subS.ToUpper());
            i = find2 + 9;
        }
        Console.WriteLine("The result:");
        Console.WriteLine(replace);
    }
}