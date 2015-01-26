//Write a program that reads from the console a sequence of positive integer numbers.
//The sequence ends when empty line is entered. Calculate and print the sum and average of the elements of the sequence.
//Keep the sequence in List<int>.

namespace _01.SumAndAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAndAverage
    {
        public static void Main()
        {
            List<int> allElements = new List<int>();
            Console.Write("Enter a sequence of positive numbers \nEnter a number: ");
            string line = Console.ReadLine();
            int number;
            int sum = 0;
            while (int.TryParse(line, out number))
            {
                if (number >= 0)
                {
                    allElements.Add(number);
                    sum += number;
                }
                Console.Write("Enter a number or empty for end: ");
                line = Console.ReadLine();
            }
            Console.WriteLine("The sum of all elements is: {0}", sum);
            Console.WriteLine("The average of all elements is: {0}", sum / allElements.Count);
        }
    }
}