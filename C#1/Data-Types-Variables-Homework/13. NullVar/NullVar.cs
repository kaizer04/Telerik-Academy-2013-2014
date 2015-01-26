using System;

class NullVar
{
    static void Main()
    {
        int? i = null;
        double? d = null;
        Console.WriteLine("The null value of int var is: {0}", i);
        Console.WriteLine("The null value of double var is: {0}", d);
        i = 14;
        d = 19.14;
        Console.WriteLine("The new value of int var is: {0}", i);
        Console.WriteLine("The new value of doble var is: {0}", d);
        i = i + null;
        Console.WriteLine("The value of int var + null literal is: {0}", i);
        d = d + null;
        Console.WriteLine("The double vaiable after adding the null litarel is: {0}", d); 
    }
}
