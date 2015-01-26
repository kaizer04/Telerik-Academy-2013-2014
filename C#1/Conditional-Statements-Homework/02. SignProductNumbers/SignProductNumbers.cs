/*Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.*/

using System;

class SignProductNumbers
{
    static void Main()
    {
        Console.Write("Please, enter 3 real numbers to show the sign of their product:\na = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        if (a >= 0 && b >= 0 && c >= 0)
        {
            Console.WriteLine("The sign of the product of three numbers is (+)");
        }
        else if (a >= 0 && b >= 0 && c < 0)
        {
            Console.WriteLine("The sign of the product of three numbers is (-)");
        }
        else if (a >= 0 && b < 0 && c >= 0)
        {
            Console.WriteLine("The sign of the product of three numbers is (-)");
        }
        else if (a >= 0 && b < 0 && c < 0)
        {
            Console.WriteLine("The sign of the product of three numbers is (+)");
        }
        else if (a < 0 && b >= 0 && c >= 0)
        {
            Console.WriteLine("The sign of the product of three numbers is (-)");
        }
        else if (a < 0 && b >= 0 && c < 0)
        {
            Console.WriteLine("The sign of the product of three numbers is (+)");
        }
        else if (a < 0 && b < 0 && c >= 0)
        {
            Console.WriteLine("The sign of the product of three numbers is (+)");
        }
        else if (a < 0 && b < 0 && c < 0)
        {
            Console.WriteLine("The sign of the product of three numbers is (-)");
        }
    }
}