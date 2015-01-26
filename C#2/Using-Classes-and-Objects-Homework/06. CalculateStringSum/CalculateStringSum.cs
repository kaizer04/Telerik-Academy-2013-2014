/*You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from given string and calculates their sum. Example:
		string = "43 68 9 23 318"  result = 461*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculateStringSum
{
    static void Main()
    {
        string numbers = "43 68 9 23 318";
        string tempNum = "";
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            while (numbers[i] != ' ' && i <= numbers.Length - 2)
            {
                tempNum = tempNum + numbers[i];
                i++;
            }
            if (i == numbers.Length - 1)
            {
                tempNum = tempNum + numbers[i];
            }
            sum += Convert.ToInt32(tempNum);
            tempNum = "";
        }
        Console.WriteLine("string = \"{0}\" --> result = {1}", numbers, sum);
    }
}