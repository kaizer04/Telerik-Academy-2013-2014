using System;

class DeclareString
{
    static void Main()
    {
        string a = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(a);
        string b = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(b);
    }
}

