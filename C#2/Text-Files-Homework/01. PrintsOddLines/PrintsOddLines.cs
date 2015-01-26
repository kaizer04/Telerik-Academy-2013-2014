/*Write a program that reads a text file and prints on the console its odd lines.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintsOddLines
{
    static void Main()
    {
        string fileName = @"..\..\..\Files\about_Arithmetic_Operators.help.txt";
        //Console.WriteLine("The contents of the file {0} is:", fileName);

        //StreamReader streamReader = new StreamReader(fileName);

        //using (streamReader)
        //{
        //    string fileContents = streamReader.ReadToEnd();
        //    Console.WriteLine(fileContents);
        //}

        //Console.WriteLine("\n\nNow line by line:");

        StreamReader reader = new StreamReader(fileName);
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                if (lineNumber % 2 == 1)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                }
                line = reader.ReadLine();
            }
        }
    }
}