/*Extend the program to support also subtraction and multiplication of polynomials.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubtractionPolynomials
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
    static int[] SubtractTwoPolynomials(int[] array1, int[] array2)
    {
        int[] arraySub = new int[array1.Length];
        for (int i = 0; i < arraySub.Length; i++)
        {
            arraySub[i] = array1[i] - array2[i];
        }
        return arraySub;
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
        Console.WriteLine("Subtracts two polynomials");
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
        Console.Write("Subtraction polynomial: ");
        PrintPolinomial(SubtractTwoPolynomials(polinomial1, polinomial2));
        Console.WriteLine();
    }
}