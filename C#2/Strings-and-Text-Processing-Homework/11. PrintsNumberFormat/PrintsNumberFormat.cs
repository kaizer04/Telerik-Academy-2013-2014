/*Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintsNumberFormat
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Decimal: {0,15:d}", number);
        Console.WriteLine("Hexadecimal: {0,15:X}", number);
        Console.WriteLine("Percent: {0,15:p}", number);
        Console.WriteLine("Scientific: {0,15:e}", number);
    }
}