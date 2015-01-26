using System;
class PrintMatrixes
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int number = 1;
        //Set some variables for the new initialization
        int currentRow;
        int currentCol;
        //string direction = "down";
        number = 1;
        currentRow = n - 1;
        currentCol = 0;
        string direction = "up";
        matrix[currentRow, currentCol] = number;
        number++;

        while (number <= n * n)
        {
            if (direction == "up")
            {
                while (matrix[currentRow, currentCol] > 0 && currentRow > 0)
                {
                    currentRow--;
                }
                if (matrix[currentRow, currentCol] > 0)
                {
                    while (matrix[currentRow, currentCol] > 0)
                    {
                        currentCol++;
                    }
                }
                if (matrix[currentRow, currentCol] == 0)
                {
                    direction = "down";
                }
            }
            if (direction == "down")
            {
                matrix[currentRow, currentCol] = number;
                if (currentRow < n - 1 && currentCol < n - 1)
                {
                    currentRow++;
                    currentCol++;
                }
                else
                {
                    while (currentCol > 0)
                    {
                        currentCol--;
                    }
                    direction = "up";
                }
            }
            number++;
        }

        //Print the matrix
        Console.WriteLine();
        Console.WriteLine("Matrix \"C\"");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }

    }
}