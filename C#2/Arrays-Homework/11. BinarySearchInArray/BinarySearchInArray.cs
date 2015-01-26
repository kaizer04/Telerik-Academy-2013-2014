/*Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinarySearchInArray
{
    static void Main()
    {
        Console.Write("Enter the element to find its index in array = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Number of array`s elements = ");
        int n = int.Parse(Console.ReadLine());
        // Declaring the array
        int[] array = new int[n];
        // Filing the array
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int a;
        
        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i + 1] < array[i])
                {
                    a = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = a;
        
                }
            }
        }
        Console.Write("Sorted array: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}, ", array[i]);
        }
        Console.WriteLine();
        int k = 0;
        int end = n - 1;
        
        for (int i = k; i <= end; i++)
        {
            int m = (k + end) / 2;
            if (b == array[m])
            {
                Console.WriteLine("The index of {0} in the array is {1}", b, m);
                break;
            }
            if (b > array[m])
            {
                k = m + 1;
            }
            else
            {
                end = m - 1;
            }
        }

    }
}