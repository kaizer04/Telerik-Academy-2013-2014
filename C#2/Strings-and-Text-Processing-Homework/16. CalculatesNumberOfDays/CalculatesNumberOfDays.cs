/*Write a program that reads two dates in the format: day.month.year and calculates the number of days between them*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class CalculatesNumberOfDays
{
    static void Main()
    {
        Console.WriteLine("Calculates the number of days between two dates");
        try
        {
            Console.Write("Enter first date [day.month.year]: ");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Enter second date [day.month.year]: ");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("The number of days between two dates: {0}", (secondDate - firstDate).Days);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid date format");
        }
    }
}