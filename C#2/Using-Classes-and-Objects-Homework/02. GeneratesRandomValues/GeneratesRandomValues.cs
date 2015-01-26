/*Write a program that generates and prints to the console 10 random values in the range [100, 200].*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GeneratesRandomValues
{
    static void Main()
    {
        Random randomGenerator = new Random();
        
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(randomGenerator.Next(100, 200) + 1);
        }
    }
}