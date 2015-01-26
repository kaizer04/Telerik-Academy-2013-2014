/*Write a program that deletes from given text file all odd lines. The result should be in the same file.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class DeletesAllOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\..\Files\task09.txt");
        StringBuilder result = new StringBuilder();
        using (reader)
        {
            int lineNum = 0;
            
            while (reader.EndOfStream != true)
            {
                string line = reader.ReadLine();
                lineNum++;
                if (lineNum % 2 == 0)
                {
                    result.Append(line);
                    result.Append("\r\n");
                }
                
            }
        }
        StreamWriter outputWriter = new StreamWriter(@"..\..\..\Files\task09.txt", false);//true - to append to existing file; false - to replace the content.
        using (outputWriter)
        {
            outputWriter.WriteLine();
            outputWriter.WriteLine(result.ToString());
        }
    }
}