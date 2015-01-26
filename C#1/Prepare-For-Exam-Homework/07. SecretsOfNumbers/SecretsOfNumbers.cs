/*Problem 2 – The Secrets of Numbers
 SEE Problem-2-Secrets-of-Numbers.doc*/

using System;
using System.Numerics;

class SecretsOfNumbers
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        int sumodd = 0;
        int sumeven = 0;
        int specialsum = 0;
        if (n < 0)
        {
            n = (-1) * n;
        }
        if (n == 0)
        {
            Console.WriteLine(n);
            Console.WriteLine("{0} has no secret alpha-sequence", n);
        }
        BigInteger n1 = n;
        //for (BigInteger i = 1; i <= n; i++)
        int i = 1;
        while (n > 0)
        {
            int a = (int)(n % 10);
            if (i % 2 == 0)
            {
                sumeven = a * a * i + sumeven;
            }
            else
            {
                sumodd = a * i * i + sumodd;
            }
            n = n / 10;
            //Console.WriteLine(n);
            i++;
        }
        specialsum = sumeven + sumodd;
        Console.WriteLine(specialsum);
        int r = specialsum % 26;
        int b = specialsum % 10;
        if (b == 0)
        {
            Console.Write("{0} has no secret alpha-sequence", n1);
        }
        for (int j = 1; j <= b; j++)
        {
            int alphabet = r + j;
            switch (alphabet)
            {
                case 1: Console.Write("A"); break;
                case 2: Console.Write("B"); break;
                case 3: Console.Write("C"); break;
                case 4: Console.Write("D"); break;
                case 5: Console.Write("E"); break;
                case 6: Console.Write("F"); break;
                case 7: Console.Write("G"); break;
                case 8: Console.Write("H"); break;
                case 9: Console.Write("I"); break;
                case 10: Console.Write("J"); break;
                case 11: Console.Write("K"); break;
                case 12: Console.Write("L"); break;
                case 13: Console.Write("M"); break;
                case 14: Console.Write("N"); break;
                case 15: Console.Write("O"); break;
                case 16: Console.Write("P"); break;
                case 17: Console.Write("Q"); break;
                case 18: Console.Write("R"); break;
                case 19: Console.Write("S"); break;
                case 20: Console.Write("T"); break;
                case 21: Console.Write("U"); break;
                case 22: Console.Write("V"); break;
                case 23: Console.Write("W"); break;
                case 24: Console.Write("X"); break;
                case 25: Console.Write("Y"); break;
                case 26: Console.Write("Z"); break;
                case 27: Console.Write("A"); break;
                case 28: Console.Write("B"); break;
                case 29: Console.Write("C"); break;
                case 30: Console.Write("D"); break;
                case 31: Console.Write("E"); break;
                case 32: Console.Write("F"); break;
                case 33: Console.Write("G"); break;
                case 34: Console.Write("H"); break;

            }
            
        }
        
    }
}

