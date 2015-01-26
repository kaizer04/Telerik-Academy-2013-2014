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

        //Console.Write("{0}, ", array[i]);
        for (int i = 0; i < array.Length; i++)
        {
            // Print each element on a separate line
            Console.Write("{0}, ", array[i]);
        }

        Console.Write("} -> {");
        int a;
        int b = 0;
        int c = 0;
        int d = 0;
        int e = 0;
        for (int i = 0; i < size - 1; i++)
        {
            a = array[i + 1];
            while ((array[i] == a) && (i < size - 1))
            {

                b++;
                i++;
                //d = a;

            }
            if (b >= c)
            {
                c = b;
                d = a;
                b = 0;
                //i = 0;
            }
            //a = array[i + 1];
            //if (array[i] == a)
            //{
            //    Console.Write("{0}, ", array[i]);
            //    Console.Write("{0}, ", array[i + 1]);
            //    //for (int i = 0; i < array.Length; i++)
            //    //{
            //    //    // Print each element on a separate line
            //    //    Console.Write("{0}, ", array[i]);
            //    //}
            //    //Console.Write(array[i]);

            //}
        }
        for (int i = 0; i < c; i++)
        {
            Console.Write("{0}, ", d);
        }
        Console.WriteLine("}");
    }
}