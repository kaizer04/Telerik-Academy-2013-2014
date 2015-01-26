using System;
// final
class ReverseDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Reverse(number);

    }
    static void Reverse(int number)
    {
        while (true)
        {
            if ((number % 10 == 0) && (number / 10 == 0))
            {
                break;
            }
            Console.Write(number % 10);
            number = number / 10;
        }
    }
}