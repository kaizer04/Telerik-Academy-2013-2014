﻿/*Write a program that reads 3 integer numbers from the console and prints their sum.*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("a + b + c = {0}", (a + b + c));
    }
}