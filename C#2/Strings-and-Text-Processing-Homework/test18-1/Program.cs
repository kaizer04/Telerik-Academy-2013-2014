using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string str = "Please contact us by phone (+359 222 222 222) or by email at exa_mple@@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";

        foreach (var item in Regex.Matches(str, @"\w+@\w+\.\w+"))
            Console.WriteLine(item);
    }
}