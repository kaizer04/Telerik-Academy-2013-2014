/*Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class AddsTwoArraysOfDigits
{
    static void Main()
        {
            Console.WriteLine("Adds two positive integer numbers represented as arrays of digits");
            Console.Write("Enter first number: ");
            BigInteger number1 = BigInteger.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            BigInteger number2 = BigInteger.Parse(Console.ReadLine());
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
            //изравнявам дължините на двата масива, за да ги събера по лесно
            if (array1.Length > array2.Length)
            {
                Array.Resize(ref array2, array1.Length);
            }
            else
            {
                Array.Resize(ref array1, array2.Length);
            }
            
            int[] array3 = new int[array1.Length + 1]; //дължината на масива в който ще събирам е +1
            int carry = 0; //числото на ум
            //цикъл за да ги събера
            for (int i = 0; i < array3.Length - 1; i++)
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
            
            array3[array3.Length - 1] = carry; //на последния елемент присвоявам числото на ум
            
            if (array3[array3.Length - 1] != 0) // ако последния елемент не е 0 го отпечатвам, ако ли не - го прескачам
            {
                Console.Write(array3[array3.Length - 1]);
            }
            for (int i = array3.Length - 2; i >= 0; i--) //отпечатвам масива наобратно, за да изглежда като число
            {

                Console.Write(array3[i]);
            }
            Console.WriteLine();
        }
}