/*using System;

class BubbleSortDemo
{
    static void Main()
    {
        int[] arr = GenerateRandomArray(10, 1, 100); // Generate a random array of 10 integers between 1 and 100
        Console.WriteLine("Original Array:");
        PrintArray(arr);

        BubbleSort(arr); // Sort the array using the Bubble Sort
        Console.WriteLine("\nSorted Array:");
        PrintArray(arr);

        bool isSorted = IsSorted(arr); // Check if the array is sorted correctly
        Console.WriteLine("\nIs the array sorted? " + isSorted);

        Console.ReadLine();
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            // If no two elements were swapped in the inner loop, the array is already sorted.
            if (!swapped)
                break;
        }
    }

    static int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = random.Next(minValue, maxValue + 1);
        }
        return arr;
    }

    static bool IsSorted(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[i - 1])
                return false;
        }
        return true;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

*/

//Performance Analysis Of the bubble sort Algo as following 


using System;
using System.Diagnostics;

class BubbleSortPerformance
{
    static void Main()
    {
        int[] arraySizes = { 100, 500, 5000, 10000 };

        Console.WriteLine("Performance Analysis of Bubble Sort\n");

        foreach (int size in arraySizes)
        {
            int[] arr = GenerateRandomArray(size, 1, 1000); // Generate random array of specified size

            // Measure the time it takes to sort the array using Bubble Sort
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            BubbleSort(arr);
            stopwatch.Stop();

            Console.WriteLine($"Array Size: {size}, Time Taken: {stopwatch.ElapsedMilliseconds} ms");
        }

        Console.ReadLine();
    }

    // Bubble Sort implementation (same as previous code)
    static void BubbleSort(int[] arr)
    {
        // ...
        // Bubble Sort algorithm implementation
        // ...
    }

    // Generate random array (same as previous code)
    static int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = random.Next(minValue, maxValue + 1);
        }
        return arr;
    }
}