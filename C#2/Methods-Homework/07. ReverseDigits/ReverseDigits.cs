/*Write a method that reverses the digits of given decimal number. Example: 256 -> 652*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseDigits
{
    static void ReverseNumberDigits(int number)
    {
        Console.Write("The reversed number is: ");
        while (number != 0)
        {
            Console.Write(number % 10);
            number = number / 10;
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        ReverseNumberDigits(number);
    }
}