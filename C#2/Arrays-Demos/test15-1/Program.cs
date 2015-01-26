using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        bool[] numbers = new bool[16];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = true;
        }

        int max = (int)Math.Sqrt(numbers.Length);

        for (int i = 2; i <= max; i++)
        {
            if (numbers[i])
            {
                for (int j = i; j < numbers.Length; j += i)
                {
                    numbers[j] = false;
                }
            }
        }
        Console.Write("2 3 ");
        for (int i = 2; i < numbers.Length; i++)
        {
            if (numbers[i])
            {
                
                Console.Write(i + " ");
            }
        }
    }
}