/*Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReturnMaxElementInPortionOfArrayStartingAtGivenIndex
{
    static int ReturnMaxElement(int n, int index)
    {
        int[] array = new int[n];
        FillArray(array);
        int max = array[index];
        for (int i = index; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        return max;
    }
    static void FillArray(int[] array)
    {
        Console.WriteLine("FILL the array");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
    }
    
    static void Main()
    {
        Console.WriteLine("Return the maximal element in a portion of array of integers starting at given index");
        Console.Write("Enter array`s lenght: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the staritng index (<{0}): ", n);
        int index = int.Parse(Console.ReadLine());
        int max = ReturnMaxElement(n, index);
        Console.WriteLine("The maximal element is {0}", max);
        Console.WriteLine();
        Console.WriteLine("Sort the array in descending order");
        SortArray(n);
    }

    static void SortArray(int n)
    {
        int[] array = new int[n];
        FillArray(array);
        int max;
        for (int i = 0; i < array.Length; i++)
        {
            max = array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] > max)
                {
                    max = array[j];
                    array[j] = array[i];
                    array[i] = max;
                }
            }

        }
        PrintArray(array);
    }
    
    static void PrintArray(int[] array)
    {
        Console.WriteLine(String.Join(", ", array));       
    }
}