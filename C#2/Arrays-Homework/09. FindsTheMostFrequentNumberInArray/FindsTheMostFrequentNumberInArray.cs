/*Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FindsTheMostFrequentNumberInArray
{
    static void Main()
    {
        Console.Write("Number of array`s elements = ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        // Filing the array
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        //int[] array = { 2, 3, -6, -1, 2, -1, 6, 4 };
        Console.Write("{");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}, ", array[i]);
        }
        Console.Write("} -> ");
        int a;
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
        //int sum = array[0];
        //int maxSum = array[0];
        //int begin = 0;
        //int finalBegin = 0;
        int c = 1;
        int b = 1;
        int d = array[0];
        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                b++;
                if (b > c)
                {
                    c = b;
                    d = array[i];
                    //b = 1;
                }
            }
            else
            {
                b = 1;
                //a = i + 1;
            }
            
        }
        
        
        Console.WriteLine("{0} ({1} times)", d, c);
        

        
    }
}