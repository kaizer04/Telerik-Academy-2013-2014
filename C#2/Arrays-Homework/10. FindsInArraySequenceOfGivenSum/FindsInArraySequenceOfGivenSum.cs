/*Write a program that finds in given array of integers a sequence of given sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FindsInArraySequenceOfGivenSum
{
    static void Main()
    {
        Console.Write("Number of array`s elements = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("The sum of a sequence: S = ");
        int s = int.Parse(Console.ReadLine());
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
        Console.Write("}, S=" + s + " -> {");

        int sum = 0;
        //int maxSum = array[0];
        int begin = 0;
        //int finalBegin = 0;
        int end = 0;
        bool finds = false;
        for (int i = 0; i < n; i++)
        {
            sum = array[i];
            for (int j = i; j < n - 1; j++)
            {
                if (sum + array[j + 1] == s)
                {
                    begin = i;
                    end = j + 1;
                    finds = true;
                }
                else
                {
                    sum = sum + array[j + 1];
                }
            }
        }

        if (finds)
        {
            for (int k = begin; k < end + 1; k++)
            {
                Console.Write("{0}, ", array[k]);
            }

            Console.WriteLine("}");
        }
        else
        {
            Console.WriteLine("not present}");
        }
    }
}