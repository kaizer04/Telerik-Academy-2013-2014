/*Write a program to convert decimal numbers to their hexadecimal representation.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertDecimalToHexadecimal
{
    static string ConvertHexadecimalChar(int n)
    {
        string ch = "";
        switch (n)
        {
            case 10:
                ch = "A";
                break;
            case 11:
                ch = "B";
                break;
            case 12:
                ch = "C";
                break;
            case 13:
                ch = "D";
                break;
            case 14:
                ch = "E";
                break;
            case 15:
                ch = "F";
                break;
        }
        return ch;
    }
    
    static void Main()
    {
        Console.WriteLine("Convert decimal numbers to their hexadecimal representation");
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());
        int numberIn = number;
        List<int> array = new List<int>();
        while (number > 0)
        {
            array.Add(number % 16);
            number = number / 16;
        }
        array.Reverse();
        Console.Write("The binary representation of {0} is ", numberIn);
        for (int i = 0; i < array.Count; i++)
        {
            if (array[i] > 9)
            {
                Console.Write("{0}", ConvertHexadecimalChar(array[i]));
            }
            else
            {
                Console.Write("{0}", array[i]);
            }

        }
        Console.WriteLine(); 
    }
}