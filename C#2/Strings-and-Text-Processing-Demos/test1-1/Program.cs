using System;

class Program
{
    static void Main()
    {
        char[] str = Console.ReadLine().ToCharArray();

        Array.Reverse(str);

        Console.WriteLine("khbkhbkj {0}" + str);
    }
}