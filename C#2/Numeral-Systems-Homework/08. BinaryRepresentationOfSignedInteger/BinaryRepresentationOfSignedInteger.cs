/*Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PBinaryRepresentationOfSignedIntegerrogram
{
    static void Main()
    {
        Console.WriteLine("Binary representation of given 16-bit signed integer number");
        Console.Write("Enter number  (-32768 <= number <= 32767): ");
        int number = int.Parse(Console.ReadLine());
        int numberIn = number;
        int[] array = new int[16];
        if (number >= 0)
        {
            int i = 0;
            while (number > 0)
            {
                array[i] = number % 2;
                number = number / 2;
                i++;
            }
          
            Console.Write("The binary representation of {0} is ", numberIn);
            for (int j = array.Length - 1; j >= 0; j--)
            {
                Console.Write("{0}", array[j]);
            }
            Console.WriteLine();
        }
        else
        {
            int numberNegative = number + 32768;
            int i = 0;
            while (numberNegative > 0)
            {
                array[i] = numberNegative % 2;
                numberNegative = numberNegative / 2;
                i++;
            }

            Console.Write("The binary representation of {0} is ", numberIn);
            Console.Write(1);
            for (int j = array.Length - 2; j >= 0; j--)
            {
                Console.Write("{0}", array[j]);
            }
            Console.WriteLine();
        }
    }
}