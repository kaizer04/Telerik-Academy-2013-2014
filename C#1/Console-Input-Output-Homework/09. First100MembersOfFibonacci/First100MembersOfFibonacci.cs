/*Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …*/

using System;
using System.Numerics;

class First100MembersOfFibonacci
{
    static void Main()
    {
        BigInteger x1 = 0;
        BigInteger x2 = 1;
        BigInteger x3;
        Console.WriteLine("The first 100 members of the sequence of Fibonacci:");
        Console.Write("{0}, ", x1);
        Console.Write("{0}, ", x2);
        for (int n = 3; n <= 100; n++)
        {
            x3 = x1 + x2;
            x1 = x2;
            x2 = x3;
            Console.Write("{0}, ", x3);
        }
    }
}