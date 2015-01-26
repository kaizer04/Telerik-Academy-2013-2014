/*Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.*/

using System;

class NotDivBy3and7
{
    static void Main()
    {
        Console.Write("Please, enter to which number, you want to print numbers not divisible by 3 and 7\nn = ");
        uint n = uint.Parse(Console.ReadLine());
        for (uint i = 1; i <= n; i++)
        {
            if (!((i % 3 != 0) || (i % 7 != 0)))
            Console.WriteLine(i);
        }
    }
}