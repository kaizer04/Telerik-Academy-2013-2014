using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _05_AreaWithMaxSum
{
    class MaxSum
    {
        static int[,] matrix;

        static void Main(string[] args)
        {
            StreamReader inputReader = new StreamReader(@"..\..\..\Files\matrix.txt");
            using (inputReader)
            {
                string line = inputReader.ReadLine();
                int matrixSize = int.Parse(line);
                matrix = new int[matrixSize, matrixSize];
                for (int i = 0; i < matrixSize; i++)
                {
                    line = inputReader.ReadLine();
                    string[] elements = line.Split(' ');
                    for (int j = 0; j < matrixSize; j++)
                    {
                        matrix[i, j] = int.Parse(elements[j]);
                    }
                }
            }
            int maxSum = int.MinValue;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int currentSum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                    }
                }

            }
            Console.WriteLine("The max sum is: {0}", maxSum);
        }
    }
}