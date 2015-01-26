/*Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReturnsIndexOfFirstElementBiggerThanNeighbors
{
    static void FillArray(int[] array)
    {
        Console.WriteLine("FILL the array");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
    }
    
    static int ReturnIndexBiggerElement()
    {
        Console.WriteLine("Returns the index of the first element in array that is bigger than its neighbors");
        Console.Write("Enter array`s lenght: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        FillArray(array);
        int index = -1;
        Console.WriteLine();
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                index = i;
                break;
            }
        }
        return index;
    }

    static void Main()
    {
        
        Console.WriteLine(ReturnIndexBiggerElement());
    }
}