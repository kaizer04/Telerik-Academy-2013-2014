/*Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.*/

using System;

class PrintAllNumbers
{
    static void Main()
    {
        int p;
        Console.Write("Please, enter to which number you want to print\nn = ");
        int n = int.Parse(Console.ReadLine());
        for (p = 1; p <= n; p++)
        {
            Console.WriteLine(p);            
        }
    }
}

