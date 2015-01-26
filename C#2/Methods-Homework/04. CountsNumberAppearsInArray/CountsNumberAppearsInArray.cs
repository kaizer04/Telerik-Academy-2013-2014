/*Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountsNumberAppearsInArray
{
    static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            array [i] = int.Parse(Console.ReadLine());
        }
    }
    static void CountsNumberInArray()
    {
        Console.Write("Counts how many times given number appears in given array\nEnter the number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter array`s lenght: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        FillArray(array);
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (number == array[i])
            {
                count++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("{0} appears {1} TIME in the array", number, count);
    }
    static void Main()
    {
        CountsNumberInArray();
    }
}