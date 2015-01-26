using System;
//using System.Numerics;

class TheHorror
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); 
        int sum = 0;
        int a = 0;
        int j = 0;
        int i = 0;
        
        if (n < 0)
        {
            n = n * (-1);
        }
        if (n == 0)
        {
            i = 1;
            sum = 0;
        }
        while (n > 0)
        {
            if (j % 2 == 0)
            {
                a = n % 10;
                sum = sum + a;
                i++;
            }
            j++;
            n = n / 10;
        }
     
        Console.WriteLine("{0} {1}", i, sum);

    }
}