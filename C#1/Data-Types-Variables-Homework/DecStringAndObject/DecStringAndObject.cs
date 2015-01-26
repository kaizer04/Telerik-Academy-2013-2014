using System;

class DecStringAndObject
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object helloWorld = hello + " " + world;
        string helloWorld2 = (string)helloWorld;
        Console.WriteLine(helloWorld2);
    }
}

