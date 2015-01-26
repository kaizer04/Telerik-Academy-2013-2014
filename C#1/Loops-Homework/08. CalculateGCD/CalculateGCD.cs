/*Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).*/

using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("Calculates the greatest common divisor (GCD) of given two numbers\nPlease, enter two numbers, for which you want to calculate GCD\na = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        int c = 1;
        while (c != 0)
        {
            c = a % b;
            a = b;
            b = c;
        }
        Console.WriteLine("The GCD for a and b is: {0}", a);
    }
}