/*Write a program that enters the coefficients a, b and c of a quadratic equation
		a*x2 + b*x + c = 0
		and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.*/

using System;

class QuadraticEquation
{
    static void Main()
    {
        double a;
        double b;
        double c;
        Console.WriteLine("A quadratic equation ax2+bx+c=0");
        Console.Write("Please, enter the coefficients a, b and c:\na = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());
        if ((b * b - 4 * a * c) > 0)
        {
            double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Console.WriteLine("x1 = {0}", x1);
            double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Console.WriteLine("x2 = {0}", x2);
        }
        else
        {
            if ((b * b - 4 * a * c) == 0)
            {
                double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                Console.WriteLine("x1 = {0}", x1);
            }
            else
            {
                Console.WriteLine("The quadratic equation has not real roots");
            }
        }
    }
}