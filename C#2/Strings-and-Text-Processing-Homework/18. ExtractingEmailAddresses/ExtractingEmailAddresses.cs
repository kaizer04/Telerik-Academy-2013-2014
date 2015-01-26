/*Write a program for extracting all email addresses from given text. All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractingEmailAddresses
{
    static void Main()
    {
        Console.WriteLine("Extracting all email addresses");
        Console.Write("Enter a text: ");
        string s = Console.ReadLine();
        string buildS = " " + s + " ";
        char[] chars = new char[] { ' ', ',', '.', '!', '?', '-' };
        string buildSub;
        for (int i = 0; i < buildS.Length; i++)
        {
            int indexAt = buildS.IndexOf("@", i);
            if (indexAt != -1)
            {
                int leftSpace = buildS.LastIndexOf(" ", indexAt);
                //Console.WriteLine(leftSpace);
                int rightSpace = buildS.IndexOf(" ", indexAt);
                buildSub = buildS.Substring(leftSpace, rightSpace - leftSpace).Trim(chars);
                if (leftSpace < indexAt - 1 && indexAt + 3 < rightSpace && buildSub.LastIndexOf(".", buildSub.Length - 3, 3) != -1)
                {
                    Console.WriteLine(buildSub);
                }
                i = rightSpace;
            }
            
        }
        
    }
}