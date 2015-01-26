using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c;
        Console.WriteLine("a={0}\nb={1}", a, b);
        c = a;
        a = b;
        b = c;
        Console.WriteLine("Exchange Values\na={0}\nb={1}", a, b);
    }
}

