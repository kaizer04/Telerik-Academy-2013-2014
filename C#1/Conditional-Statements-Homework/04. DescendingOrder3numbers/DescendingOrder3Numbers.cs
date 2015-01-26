/*Sort 3 real values in descending order using nested if statements.*/

using System;

class DescendingOrder3Numbers
{
    static void Main()
    {
        Console.Write("Please, enter 3 real numbers to sort them in descending order:\na = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        if (a > b && b > c)
        {
            Console.WriteLine("a > b > c => {0}, {1}, {2}", a, b, c);
        }
        else if (a > b && a < c)
        {
            Console.WriteLine("c > a > b => {2}, {0}, {1}", a, b, c);
        }
        else if (a < c && b > c)
        {
            Console.WriteLine("b > c > a => {1}, {2}, {0}", a, b, c);
        }
        else if (a < b && b < c)
        {
            Console.WriteLine("c > b > a => {2}, {1}, {0}", a, b, c);
        }
        else if (a < b && b > c)
        {
            Console.WriteLine("b > a > c => {1}, {0}, {2}", a, b, c);
        }
        else if (a > b && c < a)
        {
            Console.WriteLine("a > c > b => {0}, {2}, {1}", a, b, c);
        }
    }
}

