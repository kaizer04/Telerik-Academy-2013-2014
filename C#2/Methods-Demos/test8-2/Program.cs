//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
using System;
using System.Linq;
using System.Numerics;

namespace PositiveIntegers
{
    class PositiveIntegers
    {
        static void Main(string[] args)
        {


            //get number from user
            Console.WriteLine("Enter first numner: ");
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("Enter second numner: ");
            BigInteger num2 = BigInteger.Parse(Console.ReadLine());

            int[] arr1 = ConvertBigIntToArr(num1);
            int[] arr2 = ConvertBigIntToArr(num2);
            int[] arr3 = SumTwoDigitArrays(arr1, arr2);
            //Console.WriteLine(ConvertArrayToBigInteger(arr3));
            if (arr3[arr3.Length - 1] != 0)
            {
                Console.Write(arr3[arr3.Length - 1]);
            }
            for (int i = arr3.Length - 2; i >= 1; i--)
            {
                Console.Write(arr3[i]);
            }
            Console.WriteLine(arr3[0]);
        }

        //extract the digits of a number into an array;
        static int[] ConvertBigIntToArr(BigInteger n)
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
            int digits = 1;
            for (BigInteger i = 10; n / i != 0; i *= 10)
            {
                digits++;
            }
            return digits;
        }

        //sums two arrays of digits
        static int[] SumTwoDigitArrays(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[Math.Max(arr1.Length, arr2.Length) + 1];
            int carry = 0;

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                arr3[i] = (arr1[i] + arr2[i] + carry) % 10;
                if (arr1[i] + arr2[i] + carry >= 10)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
            }

            if (arr1.Length >= arr2.Length)
            {
                for (int i = arr2.Length; i < arr1.Length; i++)
                {
                    arr3[i] = arr1[i] + carry;
                    if (arr1[i] + carry >= 10)
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
                for (int i = arr1.Length; i < arr2.Length; i++)
                {
                    arr3[i] = arr2[i] + carry;
                    if (arr2[i] + carry >= 10)
                    {
                        carry = 1;
                    }
                    else
                    {
                        carry = 0;
                    }
                }
            }
            //if (carry == 0)
            //{
            //    Array.Resize(ref arr3, arr3.Length - 1);
            //}
            //else
            //{
            //    arr3[arr3.Length - 1] += carry;
            //}

            return arr3;
        }

        //converts an array of digits into an int
        //static BigInteger ConvertArrayToBigInteger(int[] arr)
        //{
        //    BigInteger num = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] == 0 && i != arr.Length - 1)
        //        {
        //            num += 1 * (BigInteger)Math.Pow(10, (double)i);
        //        }
        //        else
        //        {
        //            num += arr[i] * (BigInteger)Math.Pow(10, (double)i);
        //        }
        //    }
        //    return num;
        //}
    }
}