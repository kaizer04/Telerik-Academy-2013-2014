/*Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		x^2 + 5 = 1x^2 + 0x + 5 -> |5|0|1|*/ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AddPolynomials
{
    static void FillArray(int[] array)
    {
        //Console.WriteLine("FILL the array");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("coefficient for x^{0} = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
    }
    static int[] AddsTwoPolynomials(int[] array1, int[] array2)
    {
        int[] arraySum = new int[array1.Length];
        for (int i = 0; i < arraySum.Length; i++)
        {
            arraySum[i] = array1[i] + array2[i];
        }
        return arraySum;
    }
    static void PrintPolinomial(int[] array)
    {
        for (int i = array.Length - 1; i > 1; i--)
        {
            if (array[i] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("{0}x^{1} + ", array[i], i);
            }
        }
        if (array[1] == 0)
        {
            Console.Write("");
        }
        else
        {
            if (array[0] != 0)
            {
                Console.Write("{0}x + ", array[1]);
                Console.WriteLine(array[0]);
            }
            else
            {
                Console.Write("{0}x", array[1]);
            }
        } 
        
    }
    
    static void Main()
    {
        Console.WriteLine("Adds two polynomials");
        Console.Write("Enter the maximal degree of polynomials: ");
        int degree = int.Parse(Console.ReadLine());
        int[] polinomial1 = new int[degree + 1];
        int[] polinomial2 = new int[degree + 1];
        Console.WriteLine();
        Console.WriteLine("Enter the coefficients for the first polynomial");
        FillArray(polinomial1);
        Console.WriteLine();
        Console.WriteLine("Enter the coefficients for the second polynomial");
        FillArray(polinomial2);
        Console.WriteLine();
        Console.Write("First polynomial: ");
        PrintPolinomial(polinomial1);
        Console.WriteLine();
        Console.Write("Second polynomial: ");
        PrintPolinomial(polinomial2);
        Console.WriteLine();
        Console.Write("Added polynomial: ");
        PrintPolinomial(AddsTwoPolynomials(polinomial1, polinomial2));
        Console.WriteLine();
    }
}