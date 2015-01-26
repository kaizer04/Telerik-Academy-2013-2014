/*Write a program to convert hexadecimal numbers to their decimal representation.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ConvertHexadecimalToDecimal
{
    static long CalculateDegree(long n, int degree)
    {
        long sumDegree = 1;
        for (int i = 1; i <= degree; i++)
        {
            sumDegree *= n;
        }
        return sumDegree;
    }

    static int ConvertHexadecimalChar(string element)
    {
        int digit = 0;
        switch (element)
        {
            case "Rawr":
                digit = 0;
                break;
            case "Rrrr":
                digit = 1;
                break;
            case "Hsst":
                digit = 2;
                break;
            case "Ssst":

                digit = 3;
                break;

            case "Grrr":
                digit = 4;
                break;

            case "Rarr":
                digit = 5;
                break;
            case "Mrrr":
                digit = 6;
                break;
            case "Psst":
                digit = 7;
                break;
            case "Uaah":
                digit = 8;
                break;
            case "Uaha":

                digit = 9;
                break;

            case "Zzzz":
                digit = 10;
                break;

            case "Bauu":
                digit = 11;
                break;

            case "Djav":
                digit = 12;
                break;

            case "Myau":
                digit = 13;
                break;

            case "Gruh":
                digit = 14;
                break;
        }
        return digit;
    }

    static void Main()
    {
       // Console.WriteLine("Convert hexadecimal numbers to their decimal representation");
        //Console.Write("Enter hexadecimal number: ");
        string number = Console.ReadLine();
        string numberIn = number;
        long sum = 0;
        StringBuilder numberStr = new StringBuilder();

        for (int i = number.Length - 1, j = 0; i >= 0; i = i - 4, j++)
        {
            for (int k = i - 3; k <= i; k++)
            {
                numberStr.Append(number[k]);
            }
            
            sum += ConvertHexadecimalChar(numberStr.ToString()) * CalculateDegree(15, j);
            numberStr.Clear();

        }
        Console.WriteLine(sum);

    }

}