/*Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class ParamsMethods
{
    static int CalculateMinNumber(params int[] array)
    {
        int min = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    static int CalculateMaxNumber(params int[] array)
    {
        int max = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static long CalculateSum(params int[] array)
    {
        long sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static double CalculateAverageValue(params int[] array)
    {
        long sum = CalculateSum(10, -100, 90, 11, 3, 5, 2, -2, 1, 2, 2, 7, 10, 5, 7, 9, 37, 14, 69, 57, 75, 575, 1, 2, 4, 3); 
        double average;
        average = sum / array.Length;
        return average;
    }

    static BigInteger CalculateProduct(params int[] array)
    {
        BigInteger product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }

    static void Main()
    {
        Console.WriteLine("Minimum number: " + CalculateMinNumber( 10, 100, 90, 11, 3, 5, 2, 2, 1, 2, 2, 7, 10, 5, 7, 9, 37, 14, 69, 57, 75, 575, 1, 2, 4, 3));
        
        Console.WriteLine("Maximum number: " + CalculateMaxNumber( 10, -100, 90, 11, 3, 5, 2, -2, 1, 2, 2, 7, 10, 5, 7, 9, 37, 14, 69, 57, 75, 575, 1, 2, 4, 3));
        
        Console.WriteLine("The Sum is: " + CalculateSum( 10, -100, 90, 11, 3, 5, 2, -2, 1, 2, 2, 7, 10, 5, 7, 9, 37, 14, 69, 57, 75, 575, 1, 2, 4, 3));
        
        Console.WriteLine("Average value: " + CalculateAverageValue(10, -100, 90, 11, 3, 5, 2, -2, 1, 2, 2, 7, 10, 5, 7, 9, 37, 14, 69, 57, 75, 575, 1, 2, 4, 3));

        Console.WriteLine("The Product value is: " + CalculateProduct(10, -100, 90, 11, 3, 5, 2, -2, 1, 2, 2, 7, 10, 5, 7, 9, 37, 14, 69, 57, 75, 575, 1, 2, 4, 3));
    }
}
