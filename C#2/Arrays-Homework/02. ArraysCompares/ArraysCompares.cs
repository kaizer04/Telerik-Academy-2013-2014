/*Write a program that reads two arrays from the console and compares them element by element.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ArraysCompares
{
    static void Main()
    {
        Console.Write("Number of array`s elements = ");
        int size = int.Parse(Console.ReadLine());

        // Declaring the array
        int[] array = new int[size];

        // Filing the array
        for (int i = 0; i < size; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Number of array2`s elements = ");
        int size2 = int.Parse(Console.ReadLine());

        // Declaring the array
        int[] array2 = new int[size2];

        // Filing the array
        for (int i = 0; i < size2; i++)
        {
            Console.Write("arr2[{0}] = ", i);
            array2[i] = int.Parse(Console.ReadLine());
        }
        bool compare = false;
        if (size == size2)
        {
            for (int i = 0; i < size; i++)
            {
                if (array[i] == array2[i])
                {
                    compare = true;
                }
                else
                {
                    compare = false;
                    break;
                }
            }
            if (compare)
            {
                Console.WriteLine("The arrays are equal");
            }
            else
            {
                Console.WriteLine("The arrays are NOT equal");
            }
        }
        else
        {
            Console.WriteLine("The arrays are NOT equal");
        }

    }
}