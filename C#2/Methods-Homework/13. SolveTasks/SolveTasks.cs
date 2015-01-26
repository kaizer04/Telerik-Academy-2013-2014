/*Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
		Create appropriate methods.
		Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SolveTasks
{
    static void ReverseDigit()
    {
        Console.Write("Enter a non-negative number to revers its digits: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 0)
        {
            Console.Write("The reversed number is: ");
            while (number != 0)
            {
                Console.Write(number % 10);
                number = number / 10;
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Enter a correct number!");
        }
    }

    static void CalculateAverage()
    {
        Console.Write("Enter a number of members of the sequence: ");
        int numMembers = int.Parse(Console.ReadLine());
        double sum = 0;
        if (numMembers > 0)
        {
            for (int i = 1; i <= numMembers; i++)
            {
                Console.Write("x{0} = ", i);
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("The average of sequence is: {0}", (sum / numMembers));
        }
        else
        {
            Console.WriteLine("Enter a correct number for members of the sequence!");
        }
    }

    static void SolvesLinearEquation()
    {
        Console.WriteLine("Solves a linear equation a * x + b = 0");
        Console.WriteLine("Enter a (a!=0) and b");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        if (a != 0)
        {
            Console.WriteLine("x = {0}", (-b / a));
        }
        else
        {
            Console.WriteLine("Enter a correct value for a!");
        }
    }

    static void Main()
    {
        Console.WriteLine("Choose which task to solve");
        Console.WriteLine("0 --> EXIT");
        Console.WriteLine("1 --> Reverses the digits of a non-negative number");
        Console.WriteLine("2 --> Calculates the average of a sequence of integers");
        Console.WriteLine("3 --> Solves a linear equation a * x + b = 0");
        Console.Write("Enter a task: ");
        int task = int.Parse(Console.ReadLine());
        switch (task)
        {
            case 0:
                break;
            case 1:
                ReverseDigit();
                break;
            case 2:
                CalculateAverage();
                break;
            case 3:
                SolvesLinearEquation();
                break;
            default:
                break;
        }
    }
}