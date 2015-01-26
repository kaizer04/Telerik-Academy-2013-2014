/*14. Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).*/
//това не е мое решение, опитвах се да го разбера....

using System;
using System.Collections.Generic;

class QuickSortAlgorithmInArray
{
    static void Main()
    {
        string[] myArray = { "Vasil", "Angela", "Misho", "Zorka", "Boris", "Niki", "Ivana", "Angel", "Cate", "Desi", "Ivan", "Sofi" };
        //Print initial array
        Console.WriteLine("The initial array looks:");
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("{0, -7}", myArray[i]);
        }
        Console.WriteLine();
        Console.WriteLine();
        //General variables
        bool[] onRightPossition = new bool[myArray.Length];//To save possition on pivots after rearanging elements
        bool sorted = false; //Check the end of the process
        int start = 0; //start index of unsorted zone
        int end = myArray.Length - 1;//end index of unsorted zone
        int step = 1;//To analize how the code works
        while (!sorted)
        {
            if (start == end)//If there is only one element in unsorted zone - to save its possition and to skip all next steps
            {
                onRightPossition[start] = true;
                Console.Write("Pivot-->{0} ", myArray[start]); //Just to analize/visualize how the code works
            }
            else if (end - start == 1)//If there are only two elements in unsorted zone - to sort them faster
            {
                int compStr = CompareStrings(myArray[start], myArray[end]);
                if (compStr == 1 || compStr == 0)
                {
                    onRightPossition[start] = true;
                    onRightPossition[end] = true;
                }
                else
                {
                    string myHelp = myArray[start];
                    myArray[start] = myArray[end];
                    myArray[end] = myHelp;
                    onRightPossition[start] = true;
                    onRightPossition[end] = true;
                }
                Console.Write("Pivot-->{0} ", myArray[start]); //Just to analize/visualize how the code works
            }
            else
            {

                int pivotIndex = (start + end) / 2; //I decided to use middle element as pivot
                List<string> smaller = new List<string>();
                List<string> greater = new List<string>();
                //Combine in two subsets - bigger than pivot and smaller than pivot
                for (int k = start; k <= end; k++)
                {
                    int compStr = CompareStrings(myArray[k], myArray[pivotIndex]);
                    if ((compStr == 1 || compStr == 0) && k != pivotIndex)
                    {
                        smaller.Add(myArray[k]);
                    }
                    if (compStr == 2 && k != pivotIndex)
                    {
                        greater.Add(myArray[k]);
                    }
                }
                //Rearrange element in myArray - put pivot on the right possition
                string tempor = myArray[pivotIndex];
                int countSmallers = smaller.Count;
                string[] smallValues = smaller.ToArray();
                string[] gratValues = greater.ToArray();
                for (int i = start; i < start + countSmallers; i++)
                {
                    myArray[i] = smallValues[i - start];
                }
                myArray[start + countSmallers] = tempor;//Put pivot o the right possition
                Console.Write("Pivot-->{0} ", tempor); //Just to analize/visualize how the code works
                int indexBigger = 0;
                for (int i = start + countSmallers + 1; i <= end; i++)
                {
                    myArray[i] = gratValues[indexBigger];
                    indexBigger++;
                }
                onRightPossition[start + countSmallers] = true;//Save pivot possition as sorted
            }
            //Just to analize/visualize how the code works - print array after each step
            Console.WriteLine("Step -->{0}", step);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0,-7}", myArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Finding unsorted part of the array/Check if array is sorted
            start = -1;
            end = -1;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (!onRightPossition[i] && start < 0)
                {
                    start = i;
                    sorted = false;
                }
                if ((onRightPossition[i] || i == myArray.Length - 1) && start >= 0 && end < 0)
                {
                    if (i == myArray.Length - 1)
                    {
                        end = i;
                    }
                    else
                    {
                        end = i - 1;
                    }

                    sorted = false;
                }
                if (onRightPossition[i] && start < 0 && end < 0)
                {
                    sorted = true;
                }
            }
            step++;//I use this variable to analize the code


        }
        //Output
        Console.WriteLine("Sorted array: ");
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("{0,-7}", myArray[i]);
        }
        Console.WriteLine();



    }
    //I use code from exercise 3 as method to compare two strings
    private static int CompareStrings(string firstString, string secondString)
    {
        int exit = 3;
        int minLength = Math.Min(firstString.Length, secondString.Length);
        bool[] compare = new bool[minLength];

        for (int i = 0; i < minLength; i++)
        {
            if (firstString[i] != secondString[i])
            {
                if (firstString[i] < secondString[i])
                {
                    exit = 0; ;
                    break;
                }
                else
                {
                    exit = 2;
                    break;
                }
            }
            else
            {
                compare[i] = true;
            }

        }
        if (compare[minLength - 1] && firstString.Length > minLength)
        {
            exit = 2;
        }
        if (compare[minLength - 1] && secondString.Length > minLength)
        {
            exit = 0; ;
        }
        if (compare[minLength - 1] && secondString.Length == firstString.Length)
        {
            exit = 1;
        }
        return exit;
    }
}