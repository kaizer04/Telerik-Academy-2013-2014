﻿/*Write a program that prints to the console which day of the week is today. Use System.DateTime.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DayOfTheWeekIsToday
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine("Today is " + today.DayOfWeek);
        }
}