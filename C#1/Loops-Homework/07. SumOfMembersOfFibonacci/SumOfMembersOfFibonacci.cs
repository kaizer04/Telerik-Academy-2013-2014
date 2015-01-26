/*Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.*/

using System;

class SumOfMembersOfFibonacci
{
    static void Main()
    {
        ulong x1 = 0;
        ulong x2 = 1;
        ulong sum = 1;
        Console.Write("Calculates the sum of the first N members of the sequence of Fibonacci\nPlease, enter how many members you want to calculate\nN = ");
        int n = int.Parse(Console.ReadLine());
        if (n > 0)
        {
            if (n == 1)
            {
                Console.WriteLine("The sum of the first {0} members of the sequence of Fibonacci is {1}", n, x1);
            }
            if (n == 2)
            {
                Console.WriteLine("The sum of the first {0} members of the sequence of Fibonacci is {1}", n, x2);
            }
            if (n > 2)
            {
                for (int i = 3; i <= n; i++)
                {
                    ulong xn = x1 + x2;
                    sum += xn;
                    x1 = x2;
                    x2 = xn;
                }
                Console.WriteLine("The sum of the first {0} members of the sequence of Fibonacci is {1}", n, sum);
            }
        }
        else
        {
            Console.WriteLine("Error! Please, enter a correct number for N!");
        }
    }
}