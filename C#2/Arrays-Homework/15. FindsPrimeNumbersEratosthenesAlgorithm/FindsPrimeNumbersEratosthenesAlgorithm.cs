/*Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FindsPrimeNumbersEratosthenesAlgorithm
{
    static void Main(string[] args)
    {
        bool[] numbers = new bool[10000001];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = true;
        }

        int sqrt = (int)Math.Sqrt(numbers.Length);

        for (int i = 2; i <= sqrt; i++)
        {
            if (numbers[i])
            {
                for (int j = i; j < numbers.Length; j += i)
                {
                    numbers[j] = false;
                }
            }
        }
        Console.Write("2 3 ");
        for (int i = 2; i < numbers.Length; i++)
        {
            if (numbers[i])
            {

                Console.Write(i + " ");
            }
        }
    }
}