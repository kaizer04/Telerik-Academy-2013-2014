/*Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class FindsHowManyTimesSubstrContained
{
    static void Main()
    {
        Console.WriteLine("Finds how many times a substring is contained in a given text (perform case insensitive search)");
        Console.Write("Enter text: ");
        string s = Console.ReadLine();
        Console.Write("Enter substring to count: ");
        string subS = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int find = s.ToLower().IndexOf(subS.ToLower(), i);
            if (find != -1)
            {
                count++;
                i = find;
            }
        }
        Console.WriteLine("The result is: {0}", count);
        //Console.WriteLine(Regex.Matches(s, subS, RegexOptions.IgnoreCase).Count); //това е много тарикатско трбва ни using System.Text.RegularExpressions; и си спестяваме 10 реда заедно с for цикъла
    }
}