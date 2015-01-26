//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
using System;
using System.Linq;
using System.Numerics;

namespace PositiveIntegers
{
    class PositiveIntegers
    {
        static void Main()
        {
            Console.WriteLine("Adds two positive integer numbers represented as arrays of digits");

            //get number from user
            Console.Write("Enter first number: ");
            BigInteger number1 = BigInteger.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            BigInteger number2 = BigInteger.Parse(Console.ReadLine());

            //int[] arr1 = ConvertBigIntToArr(number1);
            //int[] arr2 = ConvertBigIntToArr(number2);
            //int[] array3 = SumTwoDigitArrays(number1, number2);
            ////Console.WriteLine(ConvertArrayToBigInteger(arr3));
            //for (int i = array3.Length - 1; i >= 1; i--)
            //{
            //    Console.Write(array3[i]);
            //}
            //Console.WriteLine(array3[0]);
            SumTwoDigitArrays(number1, number2);
        }

        //extract the digits of a number into an array;
        static int[] ConvertBigIntToArray(BigInteger n)
        {
            int[] digits = new int[GetNumberOfDigits(n)];
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = (int)(n % 10);
                n = n / 10;
            }
            return digits;
        }

        //returns the number of digits of a number
        static int GetNumberOfDigits(BigInteger n)
        {
            int numberDigits = 0;
            while (n != 0)
            {
                numberDigits++;
                n = n / 10;
            }
            return numberDigits;
        }

        //sums two arrays of digits
        static void SumTwoDigitArrays(BigInteger number1, BigInteger number2)
        {
            int[] array1 = ConvertBigIntToArray(number1);
            int[] array2 = ConvertBigIntToArray(number2);

            int[] array3 = new int[Math.Max(array1.Length, array2.Length) + 1];
            int carry = 0;

            for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
            {
                array3[i] = (array1[i] + array2[i] + carry) % 10;
                if (array1[i] + array2[i] + carry > 9)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
            }

            if (array1.Length >= array2.Length)
            {
                for (int i = array2.Length; i < array1.Length; i++)
                {
                    array3[i] = array1[i] + carry;
                    if (array1[i] + carry >= 10)
                    {
                        carry = 1;
                    }
                    else
                    {
                        carry = 0;
                    }
                }
            }
            else
            {
                for (int i = array1.Length; i < array2.Length; i++)
                {
                    array3[i] = array2[i] + carry;
                    if (array2[i] + carry >= 10)
                    {
                        carry = 1;
                    }
                    else
                    {
                        carry = 0;
                    }
                }
            }

            if (array3[array3.Length - 1] != 0)
            {
                Console.Write(array3[array3.Length - 1]);
            }
            for (int i = array3.Length - 2; i >= 1; i--)
            {

                Console.Write(array3[i]);
            }
            Console.WriteLine(array3[0]);
        }

      
    }
}