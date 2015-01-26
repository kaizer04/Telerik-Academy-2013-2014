/*Write a method that returns the last digit of given integer as an English word. Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReturnsLastDigitAsWord
{
    static string ReadNumbersName(int number)
    {
        string[] numbersNames = new string[]
        { 
            "zero", "one", "two", "three", "four", "five", "six",
            "seven", "eight", "nine" 
        };
        string numberName = numbersNames[number];
        return numberName;
    }
    static void ReturnsLastDigit()
    {
        Console.Write("Returns the last digit of given integer as an English word\nEnter an integer number: ");
        int n = int.Parse(Console.ReadLine());
        int lastDigit = Math.Abs(n % 10);
        Console.WriteLine("{0} -> {1}", n, ReadNumbersName(lastDigit));
    }
    static void Main()
    {
        ReturnsLastDigit();
    }
}