/*Write a program to convert decimal numbers to their hexadecimal representation.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertDecimalToHexadecimal
{
    static string ConvertHexadecimalChar(ulong n)
    {
        string ch = "";
        switch (n)
        {
            case 0:
                ch = "LON+";
                break;
            case 1:
                ch = "VK-";
                break;
            case 2:
                ch = "*ACAD";
                break;
            case 3:
                ch = "^MIM";
                break;
            case 4:
                ch = "ERIK|";
                break;
            case 5:
                ch = "SEY&";
                break;
            case 6:
                ch = "EMY>>";
                break;
            case 7:
                ch = "/TEL";
                break;
            case 8:
                ch = "<<DON";
                break;
        }
        return ch;
    }

    static void Main()
    {
        //Console.WriteLine("Convert decimal numbers to their hexadecimal representation");
        //Console.Write("Enter decimal number: ");
        ulong number = ulong.Parse(Console.ReadLine());
        //int numberIn = number;
        List<ulong> array = new List<ulong>();
        if (number == 0)
        {
            Console.Write("LON+");
        }
        while (number > 0)
        {
            array.Add(number % 9);
            number = number / 9;
        }
        array.Reverse();
        //Console.Write("The binary representation of {0} is ", numberIn);
        for (int i = 0; i < array.Count; i++)
        {
            //
                Console.Write(ConvertHexadecimalChar(array[i]));
            //}
            //else
            //{
            //    Console.Write("{0}", array[i]);
            //}

        }
        Console.WriteLine();
    }
}