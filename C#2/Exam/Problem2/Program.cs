using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Problem2
{
    static string Repeating(int[] input, int repeat)
    {
        int sumFirstElement = 0;
        for (int i = 0; i < repeat; i++)
        {
            sumFirstElement += input[i];
        }
        
        int sum = 0;
        int product = 1;
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
        return input5.ToString();
        //Console.WriteLine(input5);
        //Console.WriteLine(String.Join(" ", input5.ToString().Skip(0).Take(input5.Length)));
    }

    static string Repeating2(string input6, int repeat, int sumElmentIn)
    {
        int sumFirstElement = sumElmentIn;
        //for (int i = 0; i < repeat; i++)
        //{
        //    sumFirstElement += input[i];
        //}
        //Console.WriteLine(sumFirstElement);
        int sum = 0;
        BigInteger product = 1;
        for (int i = repeat; i < repeat + sumFirstElement; i++)
        {
            sum += ConvertCharToDigit(input6[i]);
            product *= ConvertCharToDigit(input6[i]);
        }
        //Console.WriteLine(sum);
        //Console.WriteLine(product);

        //input6.ToList();
        //List<int> input2 = new List<int>();

        //for (int i = 0; i < input.Count() - 4; i++)
        //{
        //    input2.Add(input[i + repeat + sumFirstElement]);
        //}

        ////for (int i = 0; i < input2.Count(); i++)
        ////{
        ////    Console.WriteLine(input2[i]);
        ////}
        ////input2.();
        ////Console.WriteLine(input2);
        StringBuilder input7 = new StringBuilder();
        for (int i = repeat + sumFirstElement; i < input6.Length; i++)
        {
            input7.Append(input6[i]);
        }
        string input8 = "" + sum + product + input7;
        //Console.WriteLine(input4);
        StringBuilder input9 = new StringBuilder();
        for (int i = 0; i < input8.Length; i++)
        {

            if (input8[i] == '0' || input8[i] == '1')
            {
                //input5.Append(input4[i]);
            }
            else
            {
                input9.Append(input8[i]);
            }
        }
        //Console.WriteLine(input5);
        //input6 = input9.ToString();
        return input9.ToString();
        //Console.WriteLine(String.Join(" ", input9.ToString().Skip(0).Take(input9.Length)));
    }

    static int ConvertCharToDigit(char element)
    {
        int digit = 0;
        switch (element)
        {
            case '0':
                digit = 0;
                break;
            case '1':
                digit = 1;
                break;
            case '2':
                digit = 2;
                break;
            case '3':

                digit = 3;
                break;

            case '4':
                digit = 4;
                break;

            case '5':
                digit = 5;
                break;
            case '6':
                digit = 6;
                break;
            case '7':
                digit = 7;
                break;
            case '8':
                digit = 8;
                break;
            case '9':

                digit = 9;
                break;

        }
        return digit;
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
        //string input16 = "";
        //if (input[0] <= input.Count)
        //{
        //    Console.WriteLine(" ", input.Skip(0).Take(input.Count));
        //}
        //else
        //{
        string input6 = Repeating(input.ToArray(), 1);
       // }
        //string input6 = input16;
        string output = "";
        for (int i = 2; i <= 100000; i++)
        {
            int sumElmentIn = 0;
            for (int j = 0; j < i; j++)
            {
                sumElmentIn += ConvertCharToDigit(input6[j]);
            }
            //Console.WriteLine(sumElmentIn);
            if (sumElmentIn <= input6.Length - i)
            {
                input6 = Repeating2(input6, i, sumElmentIn);
            }
            else
            {
                Console.WriteLine(String.Join(" ", input6.Skip(0).Take(input6.Length)));
                break;
            }
        }
        //Console.WriteLine(String.Join(" ", input6.Skip(0).Take(input6.Length)));
    }
}