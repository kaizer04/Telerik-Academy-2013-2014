/*Write a program to convert binary numbers to their decimal representation.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryNumbersDecimal
{
    static int CalculateDegree(int n, int degree)
    {
        int sumDegree = 1;
        for (int i = 1; i <= degree; i++)
        {
            sumDegree *= n; 
        }
        return sumDegree;
    }

    static void Main()
    {
        Console.WriteLine("Convert binary numbers to their decimal representation");
        Console.Write("Enter binary number: ");
        int number = int.Parse(Console.ReadLine());
        int numberIn = number;
        List<int> array = new List<int>();
        
        while (number > 0)
        {
            array.Add(number % 10);
            number = number / 10;
        }
        
        //array.Reverse();
        int sum = 0;
        for (int i = 0; i < array.Count; i++)
        {
            sum += array[i] * CalculateDegree(2, i); 
        }
        Console.WriteLine("The decimal representation of {0} is {1}", numberIn, sum);
        
    }
}