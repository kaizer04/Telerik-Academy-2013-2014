using System;
using System.Collections.Generic;
using System.Text;

class Variations
{
    static void Main()
    {
        Console.WriteLine("Enter N and K:");
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        int index = k - 1;
        int oldValue = 0;

        List<int> nums = new List<int>();
        for (int i = 0; i < k; i++)
        {
            nums.Add(1);
        }
        Console.Write("N = {0}, K = {1} -> ", n, k);
        
        while (true)
        {
            Console.Write("{");
            foreach (int item in nums)
            {
                Console.Write(item + ", ");
            }
            //for (int i = 1; i <= ; i++)
            //{
            //    Console.Write(i + ", ");
            //}
            Console.Write("}, ");

            //while (index > -1 && nums[index] == n)
            //{
            //    oldValue = nums[index];
            //    nums[index] = 1;
            //    --index;
            //}

            //if (index == -1 && oldValue == n) break;

            //++nums[index];
            //index = k - 1;
        }
    }
}