/*Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayBinSearch
{
    static void Main()
    {
        Console.WriteLine("Finds the largest number in the array which is <= K");
        Console.Write("Number of array`s elements: N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K = ");
        int k = int.Parse(Console.ReadLine());
        int k1 = k;
        // Declaring the array
        int[] array = new int[n];
        // Filing the array
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
                
        Array.Sort(array);

        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine(array[i]);
            
        //}
        Console.WriteLine();
        if (k < array[0]) //проверка К дали е по - голям от array[0] и съответно, дали въобще да го търсим
        {
            Console.WriteLine("Number not found!, Maybe k < arr[0]");
        }
        int indexK;
        //int indexK = Array.BinarySearch(array, k);
        //Console.WriteLine(indexK);
        //if (indexK >= 0)
        //{
        //    Console.WriteLine(array[indexK]);
        //}
        //else
        //{
        //    k = k - 1;
        while (k > int.MinValue)
        {
            if ((indexK = Array.BinarySearch(array, k)) >= 0)  //използвам, че ако К не е елемент от array, то индекса му е < 0
            {
                Console.WriteLine("Тhe largest number in the array which is <={0} is {1}", k1, array[indexK]);
                break;
            }
            k--;
        }
        //}
         
    }
}