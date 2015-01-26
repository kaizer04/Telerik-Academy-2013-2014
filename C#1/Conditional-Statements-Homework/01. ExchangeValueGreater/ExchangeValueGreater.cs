/*Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.*/

using System;

class ExchangeValueGreater
{
    static void Main()
    {
        int c;
        Console.Write("Please, enter 2 integer numbers:\na = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a > b => a = {0}, b = {1}", a, b);
        }
        else
        {
            Console.WriteLine("a <= b => a = {0}, b = {1}", a, b);
        }
    }
}
