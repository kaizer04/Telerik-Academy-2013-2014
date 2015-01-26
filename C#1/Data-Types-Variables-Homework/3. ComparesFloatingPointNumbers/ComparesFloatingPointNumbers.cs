using System;

class ComparesFloatingPointNumbers
{
    static void Main()
    {
        float a;
        float b;
        float precision = 0.000001f;
        bool compare;
        Console.Write("a = ");
        a = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = float.Parse(Console.ReadLine());
        compare = (Math.Abs(a - b) <= precision);
        Console.WriteLine("?a=b - {0}, precision = 0.000001", compare);
    }
}

