using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Problem2
{
    static void Repeating(int[] input, int repeat)
    {
        int sumFirstElement = 0;
        for (int i = 0; i < repeat; i++)
        {
            sumFirstElement += input[i];
        }

        int sum = 0;
        BigInteger product = 1;
        for (int i = repeat; i < repeat + sumFirstElement; i++)
        {
            sum += input[i];
            product *= input[i];
        }


        input.ToList();
        List<int> input2 = new List<int>();

        for (int i = 0; i < input.Count() - 4; i++)
        {
            input2.Add(input[i + repeat + sumFirstElement]);
        }


        StringBuilder input3 = new StringBuilder();
        for (int i = 0; i < input2.Count; i++)
        {
            input3.Append(input2[i]);
        }
        string input4 = "" + sum + product + input3;

        StringBuilder input5 = new StringBuilder();
        for (int i = 0; i < input4.Length; i++)
        {

            if (input4[i] == '0' || input4[i] == '1')
            {

            }
            else
            {
                input5.Append(input4[i]);
            }
        }

        Console.WriteLine(String.Join(" ", input5.ToString().Skip(0).Take(input5.Length)));
        //return input5.ToString();
    }

    static string Repeating2(string input, int repeat)
    {
        int sumFirstElement = 0;
        for (int i = 0; i < repeat; i++)
        {
            sumFirstElement += input[i];
        }
        //Console.WriteLine(sumFirstElement);
        int sum = 0;
        int product = 1;
        for (int i = repeat; i < repeat + sumFirstElement; i++)
        {
            sum += input[i];
            product *= input[i];
        }
        //Console.WriteLine(sum);
        //Console.WriteLine(product);

        input.ToList();
        List<int> input2 = new List<int>();

        for (int i = 0; i < input.Count() - 4; i++)
        {
            input2.Add(input[i + repeat + sumFirstElement]);
        }

        //for (int i = 0; i < input2.Count(); i++)
        //{
        //    Console.WriteLine(input2[i]);
        //}
        //input2.();
        //Console.WriteLine(input2);
        StringBuilder input3 = new StringBuilder();
        for (int i = 0; i < input2.Count; i++)
        {
            input3.Append(input2[i]);
        }
        string input4 = "" + sum + product + input3;
        //Console.WriteLine(input4);
        StringBuilder input5 = new StringBuilder();
        for (int i = 0; i < input4.Length; i++)
        {

            if (input4[i] == '0' || input4[i] == '1')
            {
                //input5.Append(input4[i]);
            }
            else
            {
                input5.Append(input4[i]);
            }
        }
        //Console.WriteLine(input5);
        return input5.ToString();
    }

    static void Main()
    {
        
        List<int> input = new List<int>(); 
        
        string element = "";
        while (true)
        {
            element = Console.ReadLine();
            if (element == "END")
            {
                break;
            }
            int number = int.Parse(element);
            input.Add(number); 
        }
       
       Repeating(input.ToArray(), 1);

        //for (int i = 2; i <= 1000000; i++)
        //{
        //    if ()
        //    Repeating2(input6, 1);
        //}
    }
}