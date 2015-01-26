/*Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.*/

using System;

class MinAndMaxNumber
{
    static void Main()
    {
        int max = Int32.MinValue;
        int min = Int32.MaxValue;
        Console.Write("Please, enter how many integer numbers, in which find the maximum and the minimum number\nn = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a sequence of numbers:\n");
        for (int i = 1; i <= n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x <= min)
            {
                min = x;
            }
            if (x >= max)
            {
                max = x;
            }
        }
        Console.WriteLine("The the minimal number of the entered sequence is: " + min);
        Console.WriteLine("The the maximal number of the entered sequence is: " + max);
    }
}
