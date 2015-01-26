/*(Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...*/

using System;
class CalculateFractions
{
    static void Main()
    {
        int i = 1;
        float v = 1f; 
        for (float j = 2; j <= 1000; j++)
        {
            v = v + i / j;
            i = i * (-1);
        }
        Console.WriteLine("v = {0:F3}", v);
    }
}