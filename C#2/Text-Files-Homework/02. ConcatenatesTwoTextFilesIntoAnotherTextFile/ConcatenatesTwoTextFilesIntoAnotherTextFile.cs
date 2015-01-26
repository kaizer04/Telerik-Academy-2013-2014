/*Write a program that concatenates two text files into another text file.*/


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConcatenatesTwoTextFilesIntoAnotherTextFile
{
    static void Main()
    {
        string fileName1 = @"..\..\..\Files\about_Arithmetic_Operators.help.txt";
        
        StreamReader reader1 = new StreamReader(fileName1);
        string fileContents1;
        using (reader1)
        {
            fileContents1 = reader1.ReadToEnd();

        }

        string OUTPUT_FILE = @"..\..\..\Files\output.txt";
        StreamWriter streamWriter = new StreamWriter(OUTPUT_FILE);

        string fileName2 = @"..\..\..\Files\cert_override.txt";
        StreamReader reader2 = new StreamReader(fileName2);
        string fileContents2;
        using (reader2)
        {
            fileContents2 = reader2.ReadToEnd();
        }
        
        using (streamWriter)
        {
            streamWriter.Write(fileContents1);
            streamWriter.Write(fileContents2);

        }

        
    }
}