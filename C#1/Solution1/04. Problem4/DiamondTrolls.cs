using System;

class DiamondTrolls
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
       
        for (int j = 0; j < 1; j++)
        {
            for (int i = 1; i <= n * 2 + 1; i++)
           
            {
                while (i <= (n - ((n - 1) / 2)))
                {
                    Console.Write(".");
                    i++;
                }
                while ((i >  (n - ((n - 1) / 2))) && (i <= (2 * n - ((n - 1) / 2))))
                {
                    Console.Write("*");
                    i++;
                }
                while ((i > (2 * n - ((n - 1) / 2))) && (i <= 2 * n + 1))
                {
                    Console.Write(".");
                    i++;
                }

            }
            Console.WriteLine();

        }

        //vtori red do 4 red
        for (int j = 1; j < ((6 + ((n - 3) / 2) * 3) - n - 1); j++)
        {
            for (int i = 1; i <= n * 2 + 1; i++)
            {
                while (i <= (((n - 1) / 2) - j + 1))
                {
                    Console.Write(".");
                    i++;
                }
                if (i == (((n - 1) / 2) - j + 2))
                {
                    Console.Write("*");
                }
                while ((i >= (n - ((n - 1) / 2) - j + 2)) && (i <= n))
                {
                    Console.Write(".");
                    i++;
                }
                if (i == n + 1)
                {
                    Console.Write("*");
                }
                while ((i > n + 1) && (i < (n + 1 + ((n - 1) / 2) + j)))
                {
                    Console.Write(".");
                    i++;
                }
                if (i == n + 1 + (((n - 1) / 2) + j))
                {
                    Console.Write("*");
                }
                while (i > (n + (((n - 1) / 2) - j + 2)) && i < (2 * n + 1))
                {
                    Console.Write(".");
                    i++;
                }
            }
            Console.WriteLine();
        }

        for (int i = 1; i <= 2 * n + 1; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();


        for (int j = 1; j <= n - 1; j++)
        {
            for (int i = 1; i <= n * 2 + 1; i++)
            {
                while (i <= j)
                {
                    Console.Write(".");
                    i++;
                }

                if (i == j + 1)
                {
                    Console.Write("*");
                }
                while ((i > j + 1) && (i <= n))
                {
                    Console.Write(".");
                    i++;
                }
                if (i == n + 1)
                {
                    Console.Write("*");
                }
                while ((i > n + 1) && (i < 2 * n + 1 - j))
                {
                    Console.Write(".");
                    i++;
                }
                if (i == 2 * n + 1 - j)
                {
                    Console.Write("*");
                }
                while ((i > 2 * n + 1 - j) && i <= (2 * n + 1))
                {
                    Console.Write(".");
                    i++;
                }
            }
            Console.WriteLine();
        }

        for (int j = 0; j < 1; j++)
        {
            for (int i = 1; i <= 2 * n + 1; i++)
            {
                while (i <= n)
                {
                    Console.Write(".");
                    i++;
                }
                if (i == n + 1)
                {
                    Console.Write("*");
                }

                while ((i > (n + 1)) && (i <= 2 * n + 1))
                {
                    Console.Write(".");
                    i++;
                }
                

            }
            Console.WriteLine();

        }

    }
}

