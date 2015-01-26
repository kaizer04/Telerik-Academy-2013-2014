/*We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.*/

using System;

class SumSubset
{
    static void Main()
    {
        Console.Write("Checks if the sum of some subset of 5 numbers is 0.\nPlease, enter 5 integer numbers:\na = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("e = ");
        int e = int.Parse(Console.ReadLine());
        if (a + b == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {0} + {1} = 0", a, b, c, d, e);
        }
        if (a + c == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {0} + {2} = 0", a, b, c, d, e);
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {0} + {3} = 0", a, b, c, d, e);
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {0} + {4} = 0", a, b, c, d, e);
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {1} + {2} = 0", a, b, c, d, e);
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {1} + {3} = 0", a, b, c, d, e);
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {1} + {4} = 0", a, b, c, d, e);
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {2} + {3} = 0", a, b, c, d, e);
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {2} + {4} = 0", a, b, c, d, e);
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {3} + {4} = 0", a, b, c, d, e);
        }
        if (a + b + c == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {0} + {1} + {2} = 0", a, b, c, d, e);
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {0} + {1} + {3} = 0", a, b, c, d, e);
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {0} + {1} + {4} = 0", a, b, c, d, e);
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {0} + {2} + {3} = 0", a, b, c, d, e);
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {0} + {2} + {4} = 0", a, b, c, d, e);
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {0} + {3} + {4} = 0", a, b, c, d, e);
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {1} + {2} + {3} = 0", a, b, c, d, e);
        }
        if (b + c + e == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {1} + {2} + {4} = 0", a, b, c, d, e);
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {1} + {3} + {4} = 0", a, b, c, d, e);
        }
        if (c + d + e == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {2} + {3} + {4} = 0", a, b, c, d, e);
        }
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {0} + {1} + {2} + {3} = 0", a, b, c, d, e);
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {0} + {1} + {2} + {4} = 0", a, b, c, d, e);
        }
        if (a + b + d + e == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {0} + {1} + {3} + {4} = 0", a, b, c, d, e);
        }
        if (a + c + d + e == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {0} + {2} + {3} + {4} = 0", a, b, c, d, e);
        }
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} -> {0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
        }
    }
}