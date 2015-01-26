/*Write a program to calculate the Nth Catalan number by given N.*/

using System;
using System.Numerics;

class CalculateCatalanNumber
{
    static void Main()
    {
        Console.Write("Calculates Catalan number by given N. Cn = (2n)!/(n+1)!*n!\nPlease, enter n for the N-th Catalan number, n>=0:\nn = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger sumDividend = 1;
        BigInteger sumn = 1;
        BigInteger sumx = 100;
        BigInteger sumcn = 1;
        BigInteger sumDivisor = 1;
        int p = 2 * n;
        int q = n;
        if (n >= 0)
        {
            for (int i = 0; i < p; p--)
            {
                sumDividend *= p;
            }
            for (int j = 0; j < q; q--)
            {
                sumn *= q;
            }
            sumx = (sumn * (n + 1));
            sumDivisor = sumx * sumn;
            sumcn = sumDividend / sumDivisor;
            Console.WriteLine("C{0} = {1}", n, sumcn);
        }
        else
        {
            Console.WriteLine("Error. Please, enter corect number for n, n>=0");
        }
    }
}