/*Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.*/

using System;
class NumberDivBy5
{
    static void Main()
    {
        int x;
        int y;
        int p = 0;
        int z;
        Console.Write("Please, enter the numbers between to find how many numbers p exist such that the reminder of the division by 5 is 0, x<=y:\nx = ");
        x = int.Parse(Console.ReadLine());
        Console.Write("y = ");
        y = int.Parse(Console.ReadLine());
        for (z = x; z <= y; z++)
        {
            if (z % 5 == 0)
            {
                p++;
            }
        }
        Console.WriteLine("p({0},{1}) = {2}", x, y, p);
    }
}
