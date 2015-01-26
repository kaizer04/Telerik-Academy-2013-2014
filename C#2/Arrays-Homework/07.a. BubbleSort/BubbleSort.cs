using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BubbleSort
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
    for (int j = array.Length - 1; j > 0; j--)
    {
            
        for (int i = 0; i < j; i++)
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
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}, ", array[i]);
    }
    }
}