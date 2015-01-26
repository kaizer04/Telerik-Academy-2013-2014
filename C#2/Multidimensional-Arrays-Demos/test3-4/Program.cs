﻿//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements 
//located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.

using System;
using System.Collections.Generic;

class MaxSeqInRowCollDiag
{
    static void Main()
    {
        //Initialization 
        //If you don't want to input you own values you can use example inputs given at the end 
        Console.WriteLine("Enter martix size: ");
        int rowN = int.Parse(Console.ReadLine());
        int colM = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rowN, colM];
        List<string> listMaxSeq = new List<string>();
        int curSum = 1, maxSum = 0, tempRow = 1, tempCol = 0;

        //Fill matrix
        for (int row = 0; row < rowN; row++)
        {
            for (int coll = 0; coll < colM; coll++)
            {
                matrix[row, coll] = Console.ReadLine();
            }
        }

        //Print main marix
        Console.WriteLine("Main marix");
        for (int row = 0; row < rowN; row++)
        {
            for (int coll = 0; coll < colM; coll++)
            {
                Console.Write("{0,5}", matrix[row, coll]);
            }
            Console.WriteLine();
        }

        //Check for max sequence in rows
        for (int row = 0; row < rowN; row++)
        {
            for (int coll = 0; coll < colM - 1; coll++)
            {
                curSum = ((matrix[row, coll] == matrix[row, coll + 1]) ? ++curSum : 1);
                if (curSum == maxSum)
                {
                    listMaxSeq.Add(matrix[row, coll]);
                }
                else if (curSum > maxSum)
                {
                    maxSum = curSum;
                    listMaxSeq.Clear();
                    listMaxSeq.Add(matrix[row, coll]);
                }
            }
            curSum = 1;
        }

        //Checks max sequence in colls

        for (int coll = 0; coll < colM; coll++)
        {
            for (int row = 0; row < rowN - 1; row++)
            {
                curSum = ((matrix[row, coll] == matrix[row + 1, coll]) ? ++curSum : 1);
                if (curSum == maxSum)
                {
                    listMaxSeq.Add(matrix[row, coll]);
                }
                else if (curSum > maxSum)
                {
                    maxSum = curSum;
                    listMaxSeq.Clear();
                    listMaxSeq.Add(matrix[row, coll]);
                }
            }
            curSum = 1;
        }

        //Check "Main diagonal" and these above it
        for (int i = 0; i < colM - 1; i++)
        {
            for (int row = 0, coll = tempCol; row < rowN - 1 && coll < colM - 1; row++, coll++)
            {
                curSum = ((matrix[row, coll] == matrix[row + 1, coll + 1]) ? ++curSum : 1);
                if (curSum == maxSum)
                {
                    listMaxSeq.Add(matrix[row, coll]);
                }
                else if (curSum > maxSum)
                {
                    maxSum = curSum;
                    listMaxSeq.Clear();
                    listMaxSeq.Add(matrix[row, coll]);
                }
            }
            tempCol++;
            curSum = 1;
        }

        //Check diagonals under "Main diagonal"
        for (int i = 0; i < rowN - 1; i++)
        {
            for (int row = tempRow, coll = 0; row < rowN - 1 && coll < colM - 1; row++, coll++)
            {
                curSum = ((matrix[row, coll] == matrix[row + 1, coll + 1]) ? ++curSum : 1);
                if (curSum == maxSum)
                {
                    listMaxSeq.Add(matrix[row, coll]);
                }
                else if (curSum > maxSum)
                {
                    maxSum = curSum;
                    listMaxSeq.Clear();
                    listMaxSeq.Add(matrix[row, coll]);
                }
            }
            tempRow++;
            curSum = 1;
        }


        //Print result
        Console.WriteLine("Max sequence is of {0} elemets", maxSum);
        for (int i = 0; i < listMaxSeq.Count; i++)
        {
            Console.Write(listMaxSeq[i] + " ");
        }
        Console.WriteLine();
    }
}

//Test cases

//3
//4
//ha
//fifi
//ho
//hi
//fo
//pa
//fifi
//xx
//xxx
//fo
//ha
//xx

//3
//4
//ha
//fifi
//ho
//hi
//fo
//ha
//hi
//xx
//xxx
//ho
//ha
//xx

//3
//3
//s
//qq
//s
//pp
//pp
//s
//pp
//qq
//s