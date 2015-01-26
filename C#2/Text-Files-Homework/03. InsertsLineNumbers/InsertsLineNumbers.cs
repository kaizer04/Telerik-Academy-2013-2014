/*Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class InsertsLineNumbers
{
    static void Main()
    {
        string fileName = @"..\..\..\Files\about_Arithmetic_Operators.help.txt";
        
        StreamReader reader = new StreamReader(fileName);

        string OUTPUT_FILE = @"..\..\..\Files\output3.txt";
        StreamWriter streamWriter = new StreamWriter(OUTPUT_FILE);

        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                //Console.WriteLine("Line {0}: {1}", lineNumber, line);
                
                streamWriter.WriteLine("Line {0}: {1}", lineNumber, line);
                
                line = reader.ReadLine();
            }
        }
        streamWriter.Close();
    }
}