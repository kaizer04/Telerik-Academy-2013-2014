/*Write a program that calculates N!/K! for given N and K (1<K<N).*/

using System;
using System.Numerics;

class CalculateNfacturialDivByKfacturial
{
    static void Main()
    {
        Console.Write("Calculates N!/K!\nPlease, enter a number for N and K, (1<K<N):\nN = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        BigInteger sumn = 1;
        BigInteger sumk = 1;
        if ((1 < k) && (k < n))
        {
            for (int i = 0; i < n; n--)
            {
                sumn *= n;
            }
            for (int j = 0; j < k; k--)
            {
                sumk *= k;
            }
        Console.WriteLine("N!/K! = {0}", sumn / sumk);
        }
        else
        {
            Console.WriteLine("Error. Please, enter corect numbers");
        }
    }
}

