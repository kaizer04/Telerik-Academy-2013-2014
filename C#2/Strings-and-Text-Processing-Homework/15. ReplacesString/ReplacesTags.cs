/*Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReplacesTags
{
    static void Main()
    {
        Console.WriteLine("Replaces in a HTML document given as string all the tags <a href=\"…\">…</a> with corresponding tags [URL=…]…/URL].");
        Console.Write("Enter a HTML document: ");
        string s = Console.ReadLine();
        StringBuilder buildS = new StringBuilder(s);
        //for (int i = 0; i < buildS.Length; i++)
        //{
            buildS = buildS.Replace("<a href=\"", "[URL=");
            buildS = buildS.Replace("\">", "]");
            buildS = buildS.Replace("</a>", "[/URL]");
      //  }
        Console.WriteLine(buildS);
    }
}