/*Write a program that prints all the numbers from 1 to N.*/

using System;

class PrintNumbers
{
    static void Main()
    {
        Console.Write("Please, enter to which number, you want to print\nn = ");
        uint n = uint.Parse(Console.ReadLine());
        for (uint i = 1; i <= n; i++)
        {
            Console.WriteLine(i);    
        }
    }
}
