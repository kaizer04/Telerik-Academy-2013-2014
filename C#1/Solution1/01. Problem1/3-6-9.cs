using System;


class Problem1369
{
    static void Main()
    {
        long a = int.Parse(Console.ReadLine());
        long b = int.Parse(Console.ReadLine());
        long c = int.Parse(Console.ReadLine());
        long r = 0;
        if (b == 3)
        {
            r = a + c;
        }
        if (b == 6)
        {
            r = a * c;
        }
        if (b == 9)
        {
            r = a % c;
        }
        if (r % 3 == 0)
        {
            Console.WriteLine(r / 3);
        }
        else
        {
            long d = r % 3;   //d = 2
           // long r1 = r - d;    //r1 = 8 - 2 = 6
           // Console.WriteLine(r1 / 3); //6/3 = 2
            Console.WriteLine(d);
        }

        Console.WriteLine(r);
    }
}