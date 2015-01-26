/*Write a program that compares two char arrays lexicographically (letter by letter).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ComparesArraysLexicographically
{
    static void Main()
    {
        Console.Write("Number of array`s elements = ");
        int size = int.Parse(Console.ReadLine());
        char[] array = new char[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = char.Parse(Console.ReadLine());
        }

        Console.Write("Number of array2`s elements = ");
        int size2 = int.Parse(Console.ReadLine());
        char[] array2 = new char[size2];

        for (int i = 0; i < size2; i++)
        {
            Console.Write("arr2[{0}] = ", i);
            array2[i] = char.Parse(Console.ReadLine());
        }
        
        bool compare = false;
        if (size == size2) // случаите когато са еднакви мсаивите - равни дължини с еднакви елементи
        {
            for (int i = 0; i < size; i++)
            {
                if (array[i] == array2[i])
                {
                    compare = true;
                }
                else
                {
                    compare = false;
                    break;
                }
            }
            if (compare)
            {
                Console.WriteLine("The arrays are equal");
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    if (array[i] != array2[i]) //проверка ако са равни дължините и ако са еднакви елементите -> да премине на следващия
                    {
                        if (array[i] < array2[i])
                        {
                            Console.WriteLine("array is before array2");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("array2 is before array");
                            break;
                        }
                    }
                }
            }
        }
        else
        {
            if (size > size2)  // правя тази проверка, за да мога даобхвана случаите когато всички елементи на двата масива са еднакви, но този с по-малка дължина (с по малко елементи) ще бъде по напред
            {
                for (int i = 0; i < size; i++)
                {
                    if (array[i] != array2[i])
                    {
                        if (array[i] < array2[i])
                        {
                            Console.WriteLine("array is before array2");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("array2 is before array");
                            break;
                        }
                    }
                }
            }
            else  
            {
                for (int i = 0; i < size2; i++)
                {
                    if (array[i] != array2[i])
                    {
                        if (array2[i] < array[i])
                        {
                            Console.WriteLine("array2 is before array");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("array is before array2");
                            break;
                        }
                    }
                }
            }
            //Console.WriteLine("The arrays are NOT equal");
        }

    }
}