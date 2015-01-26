/*Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MultipliedArray
{
    static void Main()
    {
        int[] array = new int[20];
        //for (int i = 0; i < 20; i++)
        //{
        //    Console.Write("arr[{0}] = ", i);
        //    array[i] = int.Parse(Console.ReadLine());
        //}
        for (int i = 0; i < 20; i++)
        {
            array[i] = 5 * i;
        }
        Console.WriteLine("Array`s each element multiplied by 5:");
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("arr[{0}] = {1}", i, array[i]);
        }
    }
}