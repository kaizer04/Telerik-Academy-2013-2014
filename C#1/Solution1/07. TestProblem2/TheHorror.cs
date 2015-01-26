using System;
using System.Numerics;

class TheHorror
{
    static void Main()
    {
        string x = Console.ReadLine();
        int n;
        bool y = int.TryParse(x, out n);
        int sum = 0;
        int a = 0;
        int j = 0;
        int i = 0;
        int k = 0;
        int n1 = n;
        if (y)
        {
            if (n < 0)
            {
                n = n * (-1);
            }
            if (n == 0)
            {
                i = 1;
                sum = 0;
            }
            while (n1 > 0)
            {
                
                k++;
                n = n1 / 10;
            }

            if (k % 2 != 0)
            {
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
                
            }
        }
        Console.WriteLine("{0} {1}", i, sum);
        //Console.WriteLine(j);
    }
}