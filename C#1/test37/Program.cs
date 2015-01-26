using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.PrimeNum
{
    class PrimeNum
    {
        static void Main(string[] args)
        {
            int n = 1;
            bool prime = true;
            for (int i = 2; i < Math.Sqrt((double)n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
                else
                {
                    prime = true;
                }
            }
            Console.WriteLine("Is the integer prime? " + prime);
        }
    }
}