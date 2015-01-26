//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace DivisableBy3and7
{
    using System;
    using System.Linq;

    class DivisableBy3and7
    {
        static void Main()
        {
            int[] arrayNumbers = new int[] { 35, 14, 15, 70, -17, 333, 245, 63, 35, 231, 35, 0, 21 };

            var NumbersDivisableBy3and7Lambda = arrayNumbers.Where(num => num % 3 == 0 && num % 7 == 0); //Lambda
            
            Console.WriteLine("Lambda : ");
            
            foreach (var item in NumbersDivisableBy3and7Lambda)
            {
                Console.WriteLine(item);
            }

            //LINQ
            var NumbersDivisableBy3and7LINQ = from num in arrayNumbers
                                              where num % 3 == 0 && num % 7 == 0
                                              select num;

            Console.WriteLine("LINQ : ");

            foreach (var item in NumbersDivisableBy3and7LINQ)
            {
                Console.WriteLine(item);
            }
        }
    }
}