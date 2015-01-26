/*Write a program to convert hexadecimal numbers to their decimal representation.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ConvertHexadecimalToDecimal
{
    static int CalculateDegree(int n, int degree)
    {
        int sumDegree = 1;
        for (int i = 1; i <= degree; i++)
        {
            sumDegree *= n; 
        }
        return sumDegree;
    }

    static int ConvertHexadecimalChar(char element)
    {
        int digit = 0;
        switch (element)
            {
                case 'A':
                case 'a':    
                    digit = 10; 
                    break;
                case 'B':
                case 'b':
                    digit = 11; 
                    break;
                case 'C':
                case 'c':    
                    digit = 12; 
                    break;
                case 'D':
                case 'd':    
                    digit = 13; 
                    break;
                case 'E':
                case 'e':    
                    digit = 14; 
                    break;
                case 'F':
                case 'f':    
                    digit = 15; 
                    break;
                default: 
                    digit = int.Parse(Convert.ToString(element)); 
                    break;
            }
            return digit;
    }

    static void Main()
    {
        Console.WriteLine("Convert hexadecimal numbers to their decimal representation");
        Console.Write("Enter hexadecimal number: ");
        string number = Console.ReadLine();
        string numberIn = number;
        int sum = 0;
        
        for (int i = number.Length - 1, j = 0; i >= 0; i--, j++)
        {
            sum += ConvertHexadecimalChar(number[i]) * CalculateDegree(16, j); 
        }
        Console.WriteLine("The decimal representation of {0} is {1}", numberIn, sum);
        
    }
    
}