/*Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).*/

using System;
using System.Numerics;

class CalculateNfactoriLMultiplyKfactorialDivByKminusNfactorial
{
    static void Main()
    {
        Console.Write("Calculates N!*K!/(K-N)!\nPlease, enter a number for N and K, (1<N<K):\nN = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        BigInteger sumn = 1;
        BigInteger sumk = 1;
        BigInteger summ = 1;
        int m = k - n;
        if ((0 < n) && (n < k))
        {
            for (int i = 0; i < n; n--)
            {
                sumn *= n;
            }
            for (int j = 0; j < k; k--)
            {
                sumk *= k;
            }
            for (int i = 0; i < n; n--)
            {
                sumn *= n;
            }
            for (int l = 0; l < m; m--)
            {
                summ *= m;
            }
            Console.WriteLine("N!*K!/(K-N)! = {0}", sumn * sumk / summ);
        }
        else
        {
            Console.WriteLine("Error. Please, enter corect numbers");
        }
    }
}