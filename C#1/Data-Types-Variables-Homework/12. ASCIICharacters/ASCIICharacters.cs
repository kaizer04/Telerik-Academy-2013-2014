using System;
using System.Collections.Generic;
using System.Text;

class ASCIICharacters
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (int i = 0; i < 257; i++)
        {
            Console.WriteLine(i + " = " + (char)i);
        }
    }
}

