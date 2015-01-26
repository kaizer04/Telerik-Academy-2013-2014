﻿//Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n for given integer number n.
//Example: n=3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2},{3, 2, 1}
namespace DSA_Recursion_Homework
{
    using System;

    class AllPermsForN
    {
        //static void Main()
        //{
        //    Console.Write("Enter n: ");
        //    int n = int.Parse(Console.ReadLine());
        //    int[] answer = new int[n];
        //    bool[] used = new bool[n];
        //    Permute(answer, 0, used);
        //}
    
        private static void Permute(int[] answer, int index, bool[] used)
        {
            if (index == answer.Length)
            {
                Console.WriteLine(string.Join(" ", answer));
            }
            else
            {
                for (int i = 1; i <= answer.Length; i++)
                {
                    if (!used[i - 1])
                    {
                        answer[index] = i;
                        used[i - 1] = true;
                        Permute(answer, index + 1, used);
                        used[i - 1] = false;
                    }
                }
            }
        }
    }
}