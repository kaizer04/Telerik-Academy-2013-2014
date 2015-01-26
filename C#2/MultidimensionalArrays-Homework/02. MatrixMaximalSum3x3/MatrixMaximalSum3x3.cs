/*Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixMaximalSum3x3
{
    static void Main()
    {
        Console.Write("Enter the size of the matrix N x M (N>=3 & M >=3)\nN = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("M = ");
        int m = int.Parse(Console.ReadLine());
        // Declare and initialize the matrix
        int[,] matrix = new int[n, m];
        Console.WriteLine("Enter the matrix {0} rows x {1} columns:", n, m);
        for (int i = 0; i < n; i++)
        {
            string rolStr = Console.ReadLine(); // ex. 1 2 3
            string[] emptySpace = new string[] { " " }; // remove from split empty space
            string[] colStrArray = rolStr.Split(emptySpace, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < colStrArray.Length; j++)
            {
                matrix[i, j] = int.Parse(colStrArray[j]); // Input digits in array
            }
        }

        // Find the maximal sum platform of size 3 x 3
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        // Print the result
        Console.WriteLine("The best platform 3x3 is:");
        Console.WriteLine("  {0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol +2]);
        Console.WriteLine("  {0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("  {0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
        Console.WriteLine("The maximal sum is: {0}", bestSum);
    }
}