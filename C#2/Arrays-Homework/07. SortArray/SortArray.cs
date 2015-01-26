/*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortArray
{
    static void Main()
    {
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
        //int sum = 0;
        //int b = 1;
        //int c = 1;
        //int d = 0;
        //int e = 0;
        //bool f = false;
        for (int j = 0; j < n; j++)
        {
            a = array[j];
            for (int i = j + 1; i < n; i++)
            {

                if (array[i] < a)
                {
             
                    a = array[i];
                    array[i] = array[j];
                    array[j] = a;
                    //i++;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}, ", array[i]);
        }
        //for (int i = n - k; i < n; i++)
        //{
        //    sum = sum + array[i];
        //    //Console.Write("{0}, ", array[i]);
        //}
        //Console.WriteLine("The sum of {0} maximal elements of the arrey = {1}", k, sum);
    }
}