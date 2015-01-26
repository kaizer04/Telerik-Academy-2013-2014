using System;
/*Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.*/

class CheksBit
{
    static void Main()
    {
        int n; 
	int y = 1;
	int p;
	int v;
	int n1;
	//int b;
	//int b1;
	Console.Write("Please, enter a number n = ");
        n = int.Parse(Console.ReadLine());
	Console.Write("Please, enter a position p = ");
        p = int.Parse(Console.ReadLine());
	Console.Write("Please, enter a value at the position p (v = 0 or 1) v = ");
        v = int.Parse(Console.ReadLine());
	int mask = y << p;
    if (v == 0)
    {
        n1 = n & (~mask);
    }
    else
    {
        n1 = n | (mask);
    }

	//int mask = y << p;
        //b = (n & mask) != 0 ? 1 : 0);
	Console.WriteLine("n = {0}, p = {1}, v = {2} -> {3}", n, p, v, n1);
    }
}

