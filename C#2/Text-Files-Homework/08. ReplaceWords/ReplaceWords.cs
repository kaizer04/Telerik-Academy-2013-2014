/*Modify the solution of the previous problem to replace only whole words (not substrings).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


class ReplaceWords
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\..\Files\input08.txt");
        StreamWriter outputWriter = new StreamWriter(@"..\..\..\Files\output08.txt");
        StringBuilder word = new StringBuilder();
        StringBuilder line = new StringBuilder();
        using (outputWriter)
        using (reader)
        {
            while (reader.EndOfStream != true)
            {
                string oneLine = reader.ReadLine();
                foreach (char symbol in oneLine)
                {
                    if ((symbol >= '0' && symbol <= '9') || (symbol >= 'A' && symbol <= 'Z') || (symbol >= 'a' && symbol <= 'z'))
                    {
                        word.Append(symbol);
                    }
                    else
                    {
                        string tempWord = word.ToString();
                        if ("start".ToUpper() == word.ToString().ToUpper())
                        {
                            tempWord = "finish";
                        }
                        line.Append(tempWord);
                        line.Append(symbol);
                        word.Clear();
                    }
                }
                outputWriter.WriteLine(line.ToString());
                line.Clear();
                outputWriter.Flush();
            }
        }
    }
}