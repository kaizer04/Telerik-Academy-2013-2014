/*Problem 2. Drunken Numbers
see file - 2. Drunken Numbers.doc */

using System;

class DrunkenNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //int numDigits = 0;
        int y = 0;
        int sumV = 0;
        int sumM = 0;
        int z = 0;
        for (int i = 0; i < n; i++)
        {
            int drunkNum = int.Parse(Console.ReadLine());
            if (drunkNum < 0)
            {
                drunkNum = drunkNum * (-1);
            }
            int x = drunkNum;
            int numDigits = 0;
            while (drunkNum > 0)
            {
                drunkNum = drunkNum / 10;
                numDigits++;
            }
            if (numDigits % 2 == 0)
            {
                for (int j = 1; j <= (numDigits / 2); j++)
                {
                    y = x % 10;
                    x = x / 10;
                    sumV += y;
                }
                for (int j = 1; j <= (numDigits / 2); j++)
                {
                    y = x % 10;
                    x = x / 10;
                    sumM += y;
                }
            }
            if (numDigits % 2 != 0)
            {
                for (int j = 1; j <= (numDigits / 2 + 1); j++)
                {
                    y = x % 10;
                    x = x / 10;
                    sumV += y;
                    //z = y;
                }
                x = 10 * x + y;
                for (int j = 1; j <= (numDigits / 2 + 1); j++ )
                {
                    y = x % 10;
                    x = x / 10;
                    sumM += y;
                }    
                
                //Console.WriteLine(sumM);
                //Console.WriteLine(sumV);
            }
            //sumM += sumM;
            //sumV += sumV;
            //Console.WriteLine(sumM);
            //Console.WriteLine(sumV);
        }
        //Console.WriteLine(sumM);
        //Console.WriteLine(sumV);
        if (sumM > sumV)
        {
            Console.WriteLine("M " + (sumM - sumV));
        }
        if (sumM < sumV)
        {
            Console.WriteLine("V " + (sumV - sumM));
        }
        if (sumM == sumV)
        {
            Console.WriteLine("No " + (sumM + sumV));
        }
    }
}