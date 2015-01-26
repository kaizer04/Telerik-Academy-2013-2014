/*Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


class SortListOfString
{
    static void Main()
    {
        List<string> names = new List<string>();
        StreamReader reader = new StreamReader(@"..\..\..\Files\input06.txt");
        using (reader)
        {
            while (reader.EndOfStream != true)
            {

                string line = reader.ReadLine();
                if (line != null)
                {
                    names.Add(line);
                }
            }
        }
        names.Sort();
        StreamWriter outputWriter = new StreamWriter(@"..\..\..\Files\output06.txt");
        using (outputWriter)
        {
            foreach (string name in names)
            {
                outputWriter.WriteLine(name);
            }
        }
    }
}