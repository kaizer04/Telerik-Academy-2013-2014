/*Write a program to convert decimal numbers to their binary representation.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalNumbersToBinary
{
    static void Main()
    {
        Console.WriteLine("Convert decimal numbers to their binary representation");
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());
        int numberIn = number;
        if (number == 0)
        {
            Console.Write("The binary representation of {0} is {0}", numberIn);
        }
        List<int> array = new List<int>();
        while (number > 0)
        {
            array.Add(number % 2);
            number = number / 2;
        }
        array.Reverse();
        if (numberIn != 0)
        {
            Console.Write("The binary representation of {0} is ", numberIn);
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write("{0}", array[i]);
            }
           
        }
        Console.WriteLine();
    }
}