/*Write a program to convert binary numbers to hexadecimal numbers (directly).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertBinaryToHexadecimal
{
    static string ConvertBinary(string element)
    {
        string digit = "0";

        switch (element)
        {
            case "0000":
                digit = "0";
                break;
            case "0001":
                digit = "1";
                break;
            case "0010":
                digit = "2";
                break;
            case "0011":
                digit = "3";
                break;
            case "0100":
                digit = "4";
                break;
            case "0101":
                digit = "5";
                break;
            case "0110":
                digit = "6";
                break;
            case "0111":
                digit = "7";
                break;
            case "1000":
                digit = "8";
                break;
            case "1001":
                digit = "9";
                break;
            case "1010":
                digit = "A";
                break;
            case "1011":
                digit = "B";
                break;
            case "1100":
                digit = "C";
                break;
            case "1101":
                digit = "D";
                break;
            case "1110":
                digit = "E";
                break;
            case "1111":
                digit = "F";
                break;
            default:
                break;
        }
        return digit;
    }

    static void Main()
    {
        Console.WriteLine("Convert binary numbers to hexadecimal numbers");
        Console.Write("Enter binary number: ");

        string number = Console.ReadLine();
        string numberIn = number;

        if (number.Length % 4 == 1)
        {
            number = "000" + number;
        }
        else if (number.Length % 4 == 2)
        {
            number = "00" + number;
        }
        else if (number.Length % 4 == 3)
        {
            number = "0" + number;
        }
        //Console.WriteLine(number);


        Console.Write("The hexadecimal number of {0} is ", numberIn);
        for (int i = 0; i < number.Length; i = i + 4)
        {
            string tempNumber = "";
            tempNumber = tempNumber + number[i] + number[i + 1] + number[i + 2] + number[i + 3];
            Console.Write(ConvertBinary(tempNumber));
        }
        Console.WriteLine();

    }
}