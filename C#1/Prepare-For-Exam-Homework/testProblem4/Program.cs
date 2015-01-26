/*Problem 4 - Fire*/

using System;

class Fire
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int j = 0; j < n / 2; j++)
        {
            for (int i = 1; i <= n; i++)
            {

                while (i <= n / 2 - j - 1)
                {
                    Console.Write(".");
                    i++;
                }
                if (i == n / 2 - j)
                {
                    Console.Write("#");
                }
                while ((i < n / 2 + j) && (i >= n / 2 - j))
                {
                    Console.Write(".");
                    i++;
                }
                if (i == n / 2 + j)
                {
                    Console.Write("#");
                }

                while ((i > n / 2 + j) && (i < n))
                {
                    Console.Write(".");
                    i++;
                }

            }
            Console.WriteLine();
        }
        for (int j = 0; j < n / 2 - n / 4; j++)
        //for (int j = n / 2 - n / 4; j < n; j++)
        {
            for (int i = 1; i <= n; i++)
            {
                //while ((i > n / 2 + j) && (i < n))
                //{
                //    Console.Write(".");
                //    i++;
                //}
                //if (i == n / 2 + j)
                //{
                //    Console.Write("#");
                //}
                //while ((i < n / 2 + j) && (i >= n / 2 - j))
                //{
                //    Console.Write(".");
                //    i++;
                //}
                //if (i == n / 2 - j)
                //{
                //    Console.Write("#");
                //}
                //while (i <= n / 2 - j - 1)
                //{
                //    Console.Write(".");
                //    i++;
                //}


                while (i <= j)
                {
                    Console.Write(".");
                    i++;
                }
                if (i == 1 + j)
                {
                    Console.Write("#");
                }
                while ((i > 1 + j) && (i < n - j))
                {
                    Console.Write(".");
                    i++;
                }
                if (i == n - j)
                {
                    Console.Write("#");
                }

                while ((i > n / 2 + j) && (i < n))
                {
                    Console.Write(".");
                    i++;
                }

            }
            Console.WriteLine();
        }

        for (int i = 1; i <= n; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();


        for (int j = 0; j < n / 2; j++)
        //for (int j = n / 2 - n / 4; j < n; j++)
        {
            for (int i = 1; i <= n; i++)
            {
            
                while (i <= j)
                {
                    Console.Write(".");
                    i++;
                }
                
                while ((i > j) && (i <= n /2))
                {
                    Console.Write(@"\");
                    i++;
                }
                while ((i > n / 2) && (i <= n - j))
                {
                    Console.Write("/");
                    i++;
                }
                
                while ((i > n - j) && (i <= n))
                {
                    Console.Write(".");
                    i++;
                }

            }
            Console.WriteLine();
        }
      
    }
}