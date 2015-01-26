/*Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
N = 3			N = 4
123             1234
234             2345
345             3456
                4567   */

using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Matrix NxN\nPlease, enter a positive integer number N (0 < N < 20):\nN = ");
        int n = int.Parse(Console.ReadLine());
        if (n > 0 && n < 20)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0,3}", i);
                for (int j = (i + 1); j < (n + i); j++)
                {
                    Console.Write("{0,3}", j);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Error! Please, enter N, 0 < N < 20");
        }
    }
}