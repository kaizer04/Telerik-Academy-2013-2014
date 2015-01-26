/*Problem 1 – Coffee Vending Machine
 see file - Problem-1-Coffee-Machine.doc*/

using System;

class CoffeeVendingMachine
{
    static void Main()
    {
        //Console.Write("N1 = ");
        int n1 = int.Parse(Console.ReadLine());
        //Console.Write("N2 = ");
        int n2 = int.Parse(Console.ReadLine());
        //Console.Write("N3 = ");
        int n3 = int.Parse(Console.ReadLine());
        //Console.Write("N4 = ");
        int n4 = int.Parse(Console.ReadLine());
        //Console.Write("N5 = ");
        int n5 = int.Parse(Console.ReadLine());
        double sumN = (n1 * 0.05) + (n2 * 0.1) + (n3 * 0.2) + (n4 * 0.5) + n5;
        //Console.Write("A = ");
        double a = double.Parse(Console.ReadLine());
        //Console.Write("P = ");
        double p = double.Parse(Console.ReadLine());
        if (a >= p)
        {
            if (sumN >= (a - p))
            {
                Console.WriteLine("Yes {0:F2}", (sumN - (a - p)));
            }
            else
            {
                Console.WriteLine("No {0:F2}", (a - p - sumN));
            }
        }
        else
        {
            Console.WriteLine("More {0:F2}", (p - a));
        }
    }
}

