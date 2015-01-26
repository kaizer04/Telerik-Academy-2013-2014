/*Write a program to convert hexadecimal numbers to binary numbers (directly).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertHexadecimalToBinary
{
    static int ConvertHexadecimalChar(char element)
    {
        int digit = 0;
        switch (element)
        {
            case '0':
                digit = 0000;
                break;
            case '1':
                digit = 0001;
                break;
            case '2':
                digit = 0010;
                break;
            case '3':
                digit = 0011;
                break;
            case '4':
                digit = 0100;
                break;
            case '5':
                digit = 0101;
                break;
            case '6':
                digit = 0110;
                break;
            case '7':
                digit = 0111;
                break;
            case '8':
                digit = 1000;
                break;
            case '9':
                digit = 1001;
                break;
            case 'A':
            case 'a':
                digit = 1010;
                break;
            case 'B':
            case 'b':
                digit = 1011;
                break;
            case 'C':
            case 'c':
                digit = 1100;
                break;
            case 'D':
            case 'd':
                digit = 1101;
                break;
            case 'E':
            case 'e':
                digit = 1110;
                break;
            case 'F':
            case 'f':
                digit = 1111;
                break;
            default:
                break;
        }
        return digit;
    }

    static void Main()
    {
        Console.WriteLine("Convert hexadecimal numbers to binary numbers");
        Console.Write("Enter hexadecimal number: ");
        string number = Console.ReadLine();
        string numberIn = number;

        Console.Write("The binary number of {0} is ", numberIn);
        for (int i = 0; i <= number.Length - 1; i++)
        {
            Console.Write(ConvertHexadecimalChar(number[i]));
        }
        Console.WriteLine();

    }
}