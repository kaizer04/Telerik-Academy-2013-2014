/*Write a program that extracts from given XML file all the text without the tags.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


class ExtractsText
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\..\Files\task10.xml");
        using (reader)
        {
            string text = reader.ReadToEnd();
            StringBuilder outputText = new StringBuilder();
            bool inTag = false;
            foreach (char symbol in text)
            {
                if (symbol == '<')
                {
                    inTag = true;
                }
                if (symbol == '>')
                {
                    inTag = false;
                    continue;
                }
                if (inTag == false)
                {
                    outputText.Append(symbol);
                }
            }
            Console.WriteLine(outputText.ToString());
        }
    }
}