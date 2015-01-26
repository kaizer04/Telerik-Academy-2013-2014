/*Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class ReplaceSubstring
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\..\Files\input07.txt");
        StreamWriter outputWriter = new StreamWriter(@"..\..\..\Files\output07.txt");
        StringBuilder result = new StringBuilder();
        using (outputWriter)
        using (reader)
        {
            while (reader.EndOfStream != true)
            {
                string line = reader.ReadLine();
                int startIndex = 0;
                int indexOfStart = line.IndexOf("start", StringComparison.OrdinalIgnoreCase);
                if (indexOfStart < 0)
                {
                    result.Append(line);
                }
                else
                {
                    while (indexOfStart >= 0)
                    {
                        string subStr = line.Substring(startIndex, indexOfStart - startIndex);
                        startIndex = indexOfStart + 5;
                        indexOfStart = line.IndexOf("start", startIndex, StringComparison.OrdinalIgnoreCase);
                        result.Append(subStr);
                        result.Append("finish");
                    }
                    int lastIndexOfStart = line.LastIndexOf("start", StringComparison.OrdinalIgnoreCase);
                    string lastSubstring = line.Substring(lastIndexOfStart + 5);
                    result.Append(lastSubstring);
                }
                outputWriter.WriteLine(result.ToString());
                
                result.Clear();
                outputWriter.Flush();
            }
        }
    }
}