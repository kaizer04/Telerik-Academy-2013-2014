/*Write a program that finds the greatest of given 5 variables.*/

using System;

class FindBiggestNumber2
{
    static void Main()
    {
        Console.Write("Please, enter 5 integer numbers to show the biggest of them:\na = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d = ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e = ");
        double e = double.Parse(Console.ReadLine());
        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine("The biggest number is a = {0}", a);
        }
        else if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine("The biggest numbers is b = {0}", b);
        }
        else if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine("The biggest numbers is c = {0}", c);
        }
        else if (d > a && d > b && d > c && d > e)
        {
            Console.WriteLine("The biggest numbers is d = {0}", d);
        }
        else if (e > a && e > b && e > c && e > d)
        {
            Console.WriteLine("The biggest numbers is e = {0}", e);
        }
        else
        {
            Console.WriteLine("Error: some of the biggest numbers are equal");
        }
    }
}