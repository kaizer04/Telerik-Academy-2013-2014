/*Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N*/

using System;
using System.Numerics;

class SumNfactorialdivByXdegreeN
{
    static void Main()
    {
        Console.Write("Calculates S = 1 + 1!/X + 2!/X^2 + … + N!/X^N\nPlease, enter an integer number for N and X, (N>0):\nN = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("X = ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        double sumn = 1;
        double sumx = 1;
        double s = 1;
        if (0 < n)
        {
            for (int i = 1; i <= n; i++)
            {
                sumn *= i;
                sumx *= x;
                sum = (sumn / sumx);
                s += sum;
            }
            Console.WriteLine("S = 1 + 1!/X + 2!/X^2 + ... + N!/X^N = {0}", s);
        }
        else
        {
            Console.WriteLine("Error. Please, enter corect number for N, N>0");
        }
    }
}