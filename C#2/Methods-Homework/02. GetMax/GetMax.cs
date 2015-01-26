/*Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GetMaxMethod
{
    static int GetMax(int x1, int x2)
    {
        int max = x1;
        if (x2 > x1)
        {
            return x2;
        }
        return max;
    }
    static void Main()
    {
        Console.Write("Prints the biggest integer numbers of 3 entered\nEnter the fist integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second integer: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third integer: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("The biggest integer number is " + GetMax(a, GetMax(b, c)));
        //Console.WriteLine("The biggest integer number is " + max);
    }
}
