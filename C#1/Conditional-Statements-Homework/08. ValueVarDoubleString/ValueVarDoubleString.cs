/*Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.*/

using System;

class ValueVarDoubleString
{
    static void Main()
    {  
        Console.WriteLine("Shows the value of variable - integer or double, increases with 1; string appends \"*\" at its end.");
        Console.Write("Enter integer, double or string variable: ");
        string x = Console.ReadLine(); 
        double doublex;
        bool y = double.TryParse(x, out doublex);
        switch (y)
        {
            case true:
                Console.WriteLine("The new value for this variable is {0}", doublex + 1);
                break; 
            case false:
                Console.WriteLine("The new value for this variable is {0}*", x);
                break; 
            default:
                Console.WriteLine("Error - didn`t enter the right variable");
                break;
        }
    }
}