using System;

class PrintTheFirst10MembersOfTheSequence
{
    static void Main()
    {
        int i = 1;
        for (int j = 2; j < 12; j++ )
        {
            Console.WriteLine(i / j);
            i = i*(-1);
        }
    }
}