/*Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TextFileMatrixMaximalSum
{
    static void Main()
    {
        string fileName = @"..\..\..\Files\matrix.txt";
        StreamReader reader = new StreamReader(fileName);
        //int n = int.Parse(reader.ReadLine());
        //Console.WriteLine(n);
        
       // string line = reader.ReadLine();
        int[,] matrix;
        using (reader)
        {
            string line = reader.ReadLine();
            int n = int.Parse(line);
            matrix = new int[n, n];
            
            for (int i = 0; i < n; i++)
            {
                line = reader.ReadLine();
                string[] elements = line.Split(' '); 
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(elements[j]);
                }
            }
        }

        int bestSum = int.MinValue;
        //int bestRow = 0;
        //int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    //bestRow = row;
                    //bestCol = col;
                }
            }
        }
        

        string OUTPUT_FILE = @"..\..\..\Files\output5.txt";
        StreamWriter streamWriter = new StreamWriter(OUTPUT_FILE);
        using (streamWriter)
        {
            streamWriter.WriteLine(bestSum);
        }

        //  // Print the result
        //Console.WriteLine("The best platform 3x3 is:");
        //Console.WriteLine("  {0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol +2]);
        //Console.WriteLine("  {0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        //Console.WriteLine("  {0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
        //Console.WriteLine("The maximal sum is: {0}", bestSum);


       
    }
}