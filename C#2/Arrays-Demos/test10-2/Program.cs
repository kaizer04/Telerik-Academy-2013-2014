using System;
//Write a program that finds in given array of integers a sequence of given sum S (if present). Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

class SequenceOfGivenSum
{
    static void Main()
    {
        int sumS = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int elementPositionBegin = 0;
        int elementPositionEnd = 0;
        int temp = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            temp = arr[i];

            for (int j = i; j < arr.Length - 1; j++)
            {
                if (temp + arr[j + 1] == sumS)
                {
                    elementPositionBegin = i;
                    elementPositionEnd = j + 1;
                }
                else
                {
                    Console.WriteLine("NO");
                }
                temp += arr[j + 1];
            }
        }

        for (int i = elementPositionBegin; i <= elementPositionEnd; i++)
        {
            Console.Write("{0} ", arr[elementPositionBegin]);
            elementPositionBegin++;
        }
    }
}