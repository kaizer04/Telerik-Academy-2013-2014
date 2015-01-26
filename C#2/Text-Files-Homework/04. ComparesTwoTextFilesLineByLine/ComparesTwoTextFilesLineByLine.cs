/*Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ComparesTwoTextFilesLineByLine
{
    static void Main()
    {
        string fileName1 = @"..\..\..\Files\cert_override.txt";
        StreamReader reader1 = new StreamReader(fileName1);
    
        string fileName2 = @"..\..\..\Files\cert_override2.txt";
        StreamReader reader2 = new StreamReader(fileName2);

        //int lineNumber = 0;
        int sameLine = 0;
        int difLine = 0;
        string line1 = reader1.ReadLine();
        string line2 = reader2.ReadLine();
        while (line1 != null || line2 != null)
        {
            //lineNumber++;
            //Console.WriteLine("Line {0}: {1}", lineNumber, line);
            if (line1 == line2)
            {
                sameLine++;
            }
            else
            {
                difLine++;
                //Console.Write("The different lines are: ");
                //Console.Write("{0}, ", lineNumber);
                //Console.WriteLine();
            }
            
            line1 = reader1.ReadLine();
            line2 = reader2.ReadLine();
        }
        reader1.Close();
        reader2.Close();
        Console.WriteLine("The number of lines that are the same is: " + sameLine);
        Console.WriteLine("The number of lines that are different is: " + difLine);
    }
}