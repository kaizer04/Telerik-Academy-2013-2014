/*Write a method that calculates the number of workdays between today and given date, passed as parameter. Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculatesWorkdaysBtwTodayAndGivenDate
{
    
    static void CalculateWokrdays(DateTime lastDay)
    {
        DateTime today = DateTime.Today;
        int allDays = (lastDay - today).Days;
        //би трябвало да работи за години напред. дали? :) само дето не може да фиксирам Великден, но пък винаги са 2 почивни.
        DateTime[] holidays =
          {
              new DateTime(today.Year, 1, 1),
              new DateTime(today.Year, 3, 3),
              new DateTime(today.Year, 4, 18),
              new DateTime(today.Year, 4, 21),
              new DateTime(today.Year, 5, 1),
              new DateTime(today.Year, 5, 6),
              new DateTime(today.Year, 5, 24),
              new DateTime(today.Year, 9, 6),
              new DateTime(today.Year, 9, 22),
              new DateTime(today.Year, 12, 24),
              new DateTime(today.Year, 12, 25),
              new DateTime(today.Year, 12, 26)
          };

        while (lastDay >= today)
        {
            if ((today.DayOfWeek == DayOfWeek.Saturday) || (today.DayOfWeek == DayOfWeek.Sunday))
            {
                allDays--;
            }
            else
            {
                for (int i = 0; i < holidays.Length; i++)
                {
                    if (today == holidays[i] && holidays[i].DayOfWeek != DayOfWeek.Sunday && holidays[i].DayOfWeek != DayOfWeek.Saturday)
                    {
                        allDays--;
                    }
                }
            }
            today = today.AddDays(1);
        }
        Console.WriteLine("All days are: " + allDays);
    }

    static void Main()
    {
        Console.WriteLine("Calculates the number of workdays between today and given date");
        Console.Write("Enter last day (Year.Month.Day): ");
        DateTime lastDay = DateTime.Parse(Console.ReadLine());
        
        CalculateWokrdays(lastDay);
    }
}