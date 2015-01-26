/*Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
1   8   9   16
2   7   10  15
3   6   11  14
4   5   12  13
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
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col = col + 2)
            {
                matrix[row, col] = row + col * n + 1;

                //int element = int.Parse(Console.ReadLine());
                //matrix[row, col] = element;
            }
            for (int col = 1; col < n; col = col + 2)
            {
                matrix[row, col] = (col + 1) * n - row;

                //int element = int.Parse(Console.ReadLine());
                //matrix[row, col] = element;
            }

            //matrix[row, row] = row + n;+ 1
        }
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}