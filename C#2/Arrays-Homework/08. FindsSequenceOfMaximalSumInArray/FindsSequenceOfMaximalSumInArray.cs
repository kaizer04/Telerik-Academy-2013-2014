/*Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindsSequenceOfMaximalSumInArray
{
    static void Main()
    {
        Console.Write("Number of array`s elements = ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        // Filing the array
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        //int[] array = { 2, 3, -6, -1, 2, -1, 6, 4 };
        Console.Write("{");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}, ", array[i]);
        }
        Console.Write("} -> {");
        
        int sum = array[0];
        int maxSum = array[0];
        int begin = 0;
        int finalBegin = 0;
        int end = 0;
        for (int i = 1; i < n; i++)
        {
            sum = sum + array[i];
            if (array[i] > sum)
            {
                sum = array[i];
                begin = i;
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                finalBegin = begin;
                end = i;
            }
        }
        for (int j = finalBegin; j < end + 1; j++)
        {
            Console.Write("{0}, ", array[j]);
        }
        
        Console.WriteLine("}");
    }
}