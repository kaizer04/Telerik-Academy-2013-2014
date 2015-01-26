/*Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
7   11  14 16
4   8   12 15
2   5   9  13
1   3   6  10
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FillsAndPrintsMatrixNxN
{
    static void Main()
    {
        Console.Write("Enter the size of the matrix = ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;
        int value = 1;
        
        //populate values under the main diagonal
        for (int i = n - 1; i >= 0; i--)
        {
            row = i;
            col = 0;
            while (row < n && col < n)
            {
                matrix[row++, col++] = value++;
            }
        }

        //populate values over the main diagonal
        for (int j = 1; j < n; j++)
        {
            row = j;
            col = 0;
            while (row < n && col < n)
            {
                matrix[col++, row++] = value++;
            }
        }

        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < n; cols++)
            {
                Console.Write("{0,2} ", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
     
    }
}