/*Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ChecksWhetherYearIsLeap
{
    static void Main()
    {
        Console.Write("Enter a year to check is it a leap: ");
        int year = int.Parse(Console.ReadLine());
        //DateTime year = new DateTime(yearIn);
        
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("{0} IS a leap year", year);
        }
        else
        {
            Console.WriteLine("{0} IS NOT a leap year", year);
        }
    }
}