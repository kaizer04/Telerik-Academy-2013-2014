using System;

class BinarySearchAlgorithm
{
    static void Main()
    {
        int[] array = { 0, 1};
        int searchedNumber = int.Parse(Console.ReadLine());
        int startSearch = 0;
        int endSearch = array.Length - 1;
        int middle;
        while (startSearch <= endSearch)
        {
            middle = (startSearch + endSearch) / 2;

            if (array[middle] == searchedNumber)
            {
                Console.WriteLine("Index is: {0}.", middle);
                break;
            }

            if (array[middle] < searchedNumber)
            {
                startSearch = middle + 1;
            }

            if (array[middle] > searchedNumber)
            {
                endSearch = middle - 1;
            }
        }
    }
}