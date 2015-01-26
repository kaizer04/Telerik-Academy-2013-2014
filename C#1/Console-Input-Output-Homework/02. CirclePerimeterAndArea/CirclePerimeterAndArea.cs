/*Write a program that reads the radius r of a circle and prints its perimeter and area.*/

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please, enter the radius of the circler\nr = ");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("The perimeter of a circle with radius {0}\nP = {1}", r,  (2 * Math.PI * r));
        Console.WriteLine();
        Console.WriteLine("The area of a circle with radius {0}\nS = {1}", r, (Math.PI * r * r));
    }
}