/*We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindsLongestSequenceOfEqualStringsInMatrix
{
    static void Main()
    {
        Console.Write("Enter the size of the matrix N x M\nN = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("M = ");
        int m = int.Parse(Console.ReadLine());
        // Declare and initialize the matrix
        string[,] matrix = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                string element = Console.ReadLine();
                matrix[row, col] = element;
            }
        }
        int count = 1;
        //int bestCount1 = 0;
        //int bestCount2 = 0;
        //int bestCount3 = 0;
        int bestCount = 0;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < n - 1; row++)
        {
            for (int col = 0; col < m; col++)
            {
                while (matrix[row, col] == matrix[row + 1, col])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestRow = row;
                        bestCol = col;
                    }
                }
                count = 1;
            }
        }
        //int bestCount = bestCount1;
        for (int col = 0; col < matrix.GetLength(1) - 1; col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                while (matrix[row, col] == matrix[row, col + 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestRow = row;
                        bestCol = col;
                    }
                }
                count = 1;
            }
        }
        //if (bestCount2 > bestCount)
        //{
        //    bestCount = bestCount2;
        //}
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            while (matrix[row, row] == matrix[row + 1, row + 1])
            {
                count++;
                if (count > bestCount)
                {
                    bestCount = count;
                    bestRow = row;
                    bestCol = row;
                }
            }
            count = 1;
        }
        //if (bestCount3 > bestCount)
        //{
        //    bestCount = bestCount3;
        //}
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.Write("---> ");
        for (int i = 0; i < bestCount; i++)
        {
            Console.Write("{0}, ", matrix[bestRow, bestCol]);
        }
    }
}