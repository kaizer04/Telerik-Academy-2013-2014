

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ConvertSnumeralSystemToDnumeralSystem
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

    static int ConvertCharToDigit(string element)
    {
        int digit = 0;
        switch (element)
        {
            case "Rawr":
                digit = 0;
                break;
            case "Rrrr":
            digit = 1;
                break;
            case "Hsst":
                digit = 2;
                break;
            case "Ssst":
            
                digit = 3;
                break;

            case "Grrr":
                digit = 4;
                break;

            case "Rarr":
                digit = 5;
                break;
            case "Mrrr":
                digit = 6;
                break;
            case "Psst":
                digit = 7;
                break;
            case "Uaah":
                digit = 8;
                break;
            case "Uaha":

                digit = 9;
                break;

            case "Zzzz":
                digit = 10;
                break;

            case "Bauu":
                digit = 11;
                break;

            case "Djav":
                digit = 12;
                break;

            case "Myau":
                digit = 13;
                break;

            case "Gruh":
                digit = 14;
                break;
            //case 'F':
            //case 'f':
            //    digit = 15;
            //    break;
            //default:
            //    digit = int.Parse(Convert.ToString(element));
            //    break;
        }
        return digit;
    }

    static string ConvertDigitToChar(int n)
    {
        string ch = "";
        switch (n)
        {
            case 10:
                ch = "A";
                break;
            case 11:
                ch = "B";
                break;
            case 12:
                ch = "C";
                break;
            case 13:
                ch = "D";
                break;
            case 14:
                ch = "E";
                break;
            case 15:
                ch = "F";
                break;
        }
        return ch;
    }


    static void Main(string[] args)
    {
        //Console.WriteLine("Convert from given base s to numeral system of base d (2 <= s, d <= 16)");
        //Console.Write("Enter base s: ");
        int s = 15;
        //Console.Write("Enter base d: ");
        int d = 10;
        //Console.Write("The digits of number which you want to convert from s to d must be >= 0 and < {0}\nEnter a number: ", s);

        string number = Console.ReadLine();
        string numberIn = number;
        int sumDecimal = 0;
        StringBuilder numberStr = new StringBuilder();
        for (int i = number.Length - 1, j = 0; i >= 0; i = i - 4, j++)
        {
            for (int k = i - 3; k <= i; k++)
            {
                numberStr.Append(number[k]);
            }
            sumDecimal += ConvertCharToDigit(numberStr.ToString()) * CalculateDegree(s, j);
            numberStr.Clear();
        }
        if (s == 10)
        {
            Console.WriteLine(sumDecimal);
        }
        else
        {
            List<int> array = new List<int>();
            while (sumDecimal > 0)
            {
                array.Add(sumDecimal % d);
                sumDecimal = sumDecimal / d;
            }
            array.Reverse();
            //Console.Write("The converted of {0} from base {1} to numeral system of base {2} is ", numberIn, s, d);
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] > 9)
                {
                    Console.Write(ConvertDigitToChar(array[i]));
                }
                else
                {
                    Console.Write(array[i]);
                }

            }
            Console.WriteLine();
        }

    }
}