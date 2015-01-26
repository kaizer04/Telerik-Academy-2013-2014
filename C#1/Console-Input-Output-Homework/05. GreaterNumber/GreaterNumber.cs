/*Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.*/

using System;
class GreaterNumber
{
    static void Main()
    {
        decimal x;
        decimal y;
        Console.Write("Please, enter the numbers to find which of them is greater:\nx = ");
        x = decimal.Parse(Console.ReadLine());
        Console.Write("y = ");
        y = decimal.Parse(Console.ReadLine());
        Console.WriteLine(x > y ? "The greater number is x" : "The greater number is y");
    }
}