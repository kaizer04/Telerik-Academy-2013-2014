/*Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
1   5   9   13
2   6   10  14
3   7   11  15
4   8   12  16
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
        int[ , ] matrix = new int[n, n];
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = row + col * n + 1;

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