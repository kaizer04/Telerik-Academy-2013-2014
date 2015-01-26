/*Write a program that reads an integer number and od. If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.*/

using System;

class CalculatesSquareRoot
{
    static void Main()
    {
        try
        {
            Console.Write("Enter number: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine("The number square root is: " + Math.Sqrt(number));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number1.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number2.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid number3.");
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }
    }
}