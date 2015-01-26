namespace _21.AllDistinctVariationsOfKElements
{
    using System;
    using System.Collections.Generic;

    class AllDistinctVariationsOfKElements
    {
        static void Main()
        {
            /*Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 
             * Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}*/

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            //This list will hold K number of '1'
            List<int> oList = new List<int>();

            //This list will hold latest distinct sequence every time
            List<int> memList = new List<int>(oList);

            for (int i = 0; i < k; i++)
            {
                oList.Add(1);
            }

            bool shouldIterate = true;
            bool isFirstTime = true;

            while (shouldIterate)
            {
                int pos = 0;

                //In the first case we know that all next numbers are with one greater than the previous one
                if (isFirstTime)
                {
                    while (pos < k)
                    {
                        if (pos != 0)
                        {
                            oList[pos] = oList[pos - 1] + 1;
                        }
                        pos++;
                    }
                    Console.WriteLine(string.Join(",", oList));
                    memList = new List<int>(oList);
                    isFirstTime = false;
                }
                else
                {
                    //Incrementing rightest number with one
                    while (memList[k - 1] < n)
                    {
                        oList[k - 1]++;
                        Console.WriteLine(string.Join(",", oList));
                        memList = new List<int>(oList);
                    }

                    // Get one element back and check if it is smaller or equal to n - 2. If answer on this condition - increment by 1
                    for (int i = k - 2; i >= 0; i--)
                    {
                        if (oList[i] < n - 1)
                        {
                            oList[i]++;
                            memList = new List<int>(oList);
                            memList[k - 1] = oList[i];
                            oList[i + 1] = memList[k - 1];
                            break;
                        }
                    }

                    //Start with pos = 0
                    //Example: If oList[0] == oList[1] => oList[1]++; If oList[1] == oList[2] => oList[2]++ and so on till pos < k - 2
                    //because k - 2 is equal to the number before last one
                    while (pos < k - 2)
                    {
                        if (oList[pos] == oList[pos + 1])
                        {
                            oList[pos + 1]++;
                        }
                        pos++;

                        //Rightest number gets the value from the number before it
                        if (pos == k - 2)
                        {
                            if (oList[k - 2] < n)
                            {
                                oList[k - 1] = oList[k - 2];
                            }
                            else
                            {
                                shouldIterate = false;
                            }
                        }
                    }
                }
            }
        }
    }
}