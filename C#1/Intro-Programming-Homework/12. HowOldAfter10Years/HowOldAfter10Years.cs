using System;

class HowOldAfter10Years
{
    static void Main()
    {
        int i;
        Console.Write("How old are you: ");
        i = int.Parse(Console.ReadLine());
        Console.WriteLine("After 10 years you will be: {0}", i + 10);
        
    }
}

