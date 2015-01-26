/*Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum.*/

using System;

class NumberSum
{
    static void Main()
    {
        uint p = 1;
        double v = 0;
        double v1 = 0;
        Console.Write("Please, enter how many numbers you want to calculate\nn = ");
        uint n = uint.Parse(Console.ReadLine());
        for (p = 1; p <= n; p++)
        {
            Console.Write("V{0} = ", p);
            v = double.Parse(Console.ReadLine());
            v1 = v1 + v;
        }
        Console.WriteLine("V1 + V2 + .... + Vn = {0}", v1);
    }
}

