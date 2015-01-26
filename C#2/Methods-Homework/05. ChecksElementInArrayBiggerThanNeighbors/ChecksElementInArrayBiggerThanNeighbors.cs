/*Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ChecksElementInArrayBiggerThanNeighbors
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
    static bool CheckPosition(int pos, int n)
    {
        if (pos <= 0 || pos >= n)
        {
            Console.WriteLine("Enter a correct position!");
            return false;
        }
        else
        {
            return true;
        }
        
    }
    static void CheckBiggerNeighbors()
    {
        Console.WriteLine("Checks if the element at given position in the array of integers is bigger than its two neighbor");
        Console.Write("Enter array`s lenght: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the POSITION (>0 & <{0}) of element:", n - 1);
        int pos = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        //CheckPosition(pos,n);
        if (CheckPosition(pos, n))
        {
            FillArray(array);
            Console.WriteLine();
            if (array[pos] > array[pos - 1] && array[pos] > array[pos + 1])
            {
                Console.WriteLine("The elementi IS BIGGER than its two neighbor!");
            }
            else
            {
                Console.WriteLine("The elementi IS NOT BIGGER than its two neighbor!");
            }
        }

    }
    
    static void Main()
    {
        CheckBiggerNeighbors();
    }
}