/*Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculateSurfaceOfTriangle

{
    static void SideAndAltitude()
    {
        Console.WriteLine("1. Side and an altitude to it");
        Console.Write("Enter side: ");
        double a = double.Parse(Console.ReadLine());
 
        Console.Write("Enter altitude: ");
        double ha = double.Parse(Console.ReadLine());
 
        double s = (a * ha) / 2;
        Console.WriteLine("The surface of the triangle is: " + s);
    }

    static void ThreeSides()
    {
        Console.WriteLine("2. Three sides");
        Console.Write("Enter first side: ");
        double a = double.Parse(Console.ReadLine());
 
        Console.Write("Enter second side: ");
        double b = double.Parse(Console.ReadLine());
 
        Console.Write("Enter third side: ");
        double c = double.Parse(Console.ReadLine());
 
        double semiP = (a + b + c) / 2;
        double s = Math.Sqrt(semiP *(semiP - a) * (semiP - b) * (semiP - c));
        Console.WriteLine("The surface of the triangle is: " + s);
    }

    static void TwoSidesAndAngle()
    {
        Console.WriteLine("3. Two sides and an angle between them");
        Console.Write("Enter first side: ");
        double a = double.Parse(Console.ReadLine());
 
        Console.Write("Enter second side: ");
        double b = double.Parse(Console.ReadLine());
 
        Console.Write("Enter angle: ");
        double angleab = double.Parse(Console.ReadLine());
 
        double s = (a * b * Math.Sin(Math.PI * angleab / 180)) / 2;
        Console.WriteLine("The surface of the triangle is: " + s);
    }
 
    static void Main()
    {
        Console.WriteLine("Calculate the surface of a triangle by given:");
        Console.WriteLine("1. Side and an altitude to it;");
        Console.WriteLine("2. Three sides;");
        Console.WriteLine("3. Two sides and an angle between them.");
        Console.Write("Enter your choise: ");
        int task = int.Parse(Console.ReadLine());
        Console.WriteLine();
 
        switch (task)
        {
            case 1:
                SideAndAltitude();
                break;
            case 2:
                ThreeSides();
                break;
            case 3:
               TwoSidesAndAngle();
                break;
            default:
                Console.WriteLine("Wrong choise. Try again!");
                Main();
                break;
        }
    }
}