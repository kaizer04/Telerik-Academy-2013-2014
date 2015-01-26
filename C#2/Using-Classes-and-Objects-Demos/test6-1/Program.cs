﻿using System;

class CalculateValuesSum
{
    static void CalculateSum(string inputNumber)
    {
        string numbers = inputNumber.Split(' ');

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            int temp = Convert.ToInt32(numbers[i]);
            sum = sum + temp;
        }
        Console.WriteLine("The sum of the numbers is: " + sum);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter some numbers with a space between them: ");
        string inputNumber = Console.ReadLine();

        CalculateSum(inputNumber);
    }
}