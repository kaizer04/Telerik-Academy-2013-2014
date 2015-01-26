/*Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class DeletesWordsStartWithTest
{
    static void Main()
    {
        string prefix = "test";
        StringBuilder word = new StringBuilder();
        StringBuilder text = new StringBuilder();
        StreamReader reader = new StreamReader(@"..\..\..\Files\task11.txt");
        using (reader)
        {
            while (reader.EndOfStream != true)
            {
                string line = reader.ReadLine();
                foreach (char symbol in line)
                {
                    if ((symbol >= '0' && symbol <= '9') || (symbol >= 'A' && symbol <= 'Z') || (symbol >= 'a' && symbol <= 'z') || symbol == '_')
                    {
                        word.Append(symbol);
                    }
                    else
                    {
                        string tempWord = word.ToString();
                        if (tempWord.Length > prefix.Length)
                        {
                            if (prefix == tempWord.Substring(0, prefix.Length))
                            {
                                word.Clear();
                            }
                        }
                        text.Append(word.ToString());
                        text.Append(symbol);
                        word.Clear();
                    }
                }
            }
        }
        StreamWriter outputWriter = new StreamWriter(@"..\..\..\Files\task11.txt");
        using (outputWriter)
        {
            outputWriter.WriteLine(text.ToString());
        }
    }
}