/*Write a program that finds the biggest of three integers using nested if statements.*/

using System;

class FindBiggestNumber
{
    static void Main()
    {
        Console.Write("Please, enter 3 integer numbers to show the biggest of them:\na = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        if (a > b && a > c)
        {
            Console.WriteLine("The biggest number is a = {0}", a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("The biggest numbers is b = {0}", b);
        }
        else if (c > a && c > b)
        {
            Console.WriteLine("The biggest numbers is c = {0}", c);
        }
        //else if (a < b && b < c)
        //{
        //    Console.WriteLine("The biggest numbers is c = {0}", c);
        //}
        //else if (a < c && b > c)
        //{
        //    Console.WriteLine("The biggest numbers is b = {0}", b);
        //}
        //else if (a > b && c < a)
        //{
        //    Console.WriteLine("The biggest numbers is a = {0}", a);
        //}
        else
        {
            Console.WriteLine("Error: some of the numbers are equal");
        }
    }
}