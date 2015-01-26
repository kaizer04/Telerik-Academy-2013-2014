/*You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortsArrayByLength
{
  
    static void Main()
    {
        Console.Write("Enter number of array`s elements you want to sort by lenght: ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = Console.ReadLine();
        }
        
        Array.Sort(array, (x, y) => (x.Length).CompareTo(y.Length));
        Console.WriteLine("Elements sorted by lenght:");
        foreach (string element in array)
        {
            Console.WriteLine(element);
        }
    }
}