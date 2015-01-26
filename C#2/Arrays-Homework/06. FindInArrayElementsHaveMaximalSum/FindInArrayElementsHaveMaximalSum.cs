/*Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindInArrayElementsHaveMaximalSum
{
    static void Main()
    {
        Console.Write("Number of array`s elements = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Number of elements that have maximal sum = ");
        int k = int.Parse(Console.ReadLine());
        // Declaring the array
        int[] array = new int[n];
        // Filing the array
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        //Console.Write("{");
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Console.Write("{0}, ", array[i]);
        //}

        //Console.Write("} -> {");
        int a;
        int sum = 0;
        //int b = 1;
        //int c = 1;
        //int d = 0;
        //int e = 0;
        //bool f = false;
        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    a = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = a;
                    //i++;
                }
            }
        }
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("{0}, ", array[i]);
        //}
        for (int i = n - k; i < n; i++)
        {
            sum = sum + array[i];
            //Console.Write("{0}, ", array[i]);
        }
        Console.WriteLine("The sum of {0} maximal elements of the arrey = {1}", k, sum);
    }
}