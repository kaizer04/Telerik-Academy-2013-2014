using System;

class FillMatrix
{
        //TODO: edit
    static int[,] FillMatrixC(int n)
    {
        int[,] matrix = new int[n, n];
        int rows = 0;
        int cols = 0;
        int value = 1;

        //populate values under the main diagonal
        for (int i = n - 1; i >= 0; i--)
        {
            rows = i;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[rows++, cols++] = value++;
            }
        }

        //populate values over the main diagonal
        for (int j = 1; j < n; j++)
        {
            rows = j;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[cols++, rows++] = value++;
            }
        }
        return matrix;
    }
    

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0, -4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        //int n = 4;
        Console.Write("Enter the size of the matrix = ");
        int n = int.Parse(Console.ReadLine());
        int[,] a = FillMatrixC(n);
        PrintMatrix(a);
    }
}