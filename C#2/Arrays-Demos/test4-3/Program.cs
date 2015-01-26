/*Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindsMaxSequenceOfEqualElements
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
        Console.Write("{");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}, ", array[i]);
        }

        Console.Write("} -> {");
        int a = 0;
        int b = 1;
        int c = 1;
        int d = 0;
        int e = 0;
        bool f = false;
        for (int i = 0; i < size - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                b++;
                if (b > c)
                {
                    c = b;
                    d = a;

                }
                //    a = array[i];

            }
            else 
            {
                b = 1;
                a = i + 1;
            }
            
        }
        for (int i = d; i < d + c; i++)
        {
            Console.Write("{0}, ", array[i]);
        }
        Console.WriteLine("}");
    }
}