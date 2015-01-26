/*Problem 2. Drunken Numbers
see file - 2. Drunken Numbers.doc */

//IT`s NOT FINISHED

using System;

class DrunkenNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int numDigits = 0;
        int y;
        int sumV = 0;
        int sumM = 0;
        //int z;
        for (int i = 0; i < n; i++)
        {
            int drunkNum = int.Parse(Console.ReadLine());
            if (drunkNum < 0)
            {
                drunkNum = drunkNum * (-1);
            }
            int x = drunkNum;
            while (drunkNum > 0)
            {
                drunkNum = drunkNum / 10;
                numDigits++;
            }
            if (numDigits % 2 == 0)
            { 
                for (int j = 1; j <= numDigits; j++)
                {
                    if (j <= numDigits / 2)
                    {
                        y = x % 10;
                        x = x / 10;
                        sumV += y;
                    }
                    if (j > numDigits / 2)
                    {
                        y = x % 10;
                        x = x / 10;
                        sumM += y;
                    } 
                }
                //sumM += sumM;
                //sumV += sumV;
                Console.WriteLine(sumM);
                Console.WriteLine(sumV);
            }
            
            //Console.WriteLine(sumM);
            //Console.WriteLine(sumV);
        }
    }
}