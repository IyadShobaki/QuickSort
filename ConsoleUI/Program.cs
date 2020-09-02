using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //In-place algorithm
            // O(nlogn) - base 2 -> Time complexity for average cases
            // Quadratic O(n^2) for worst case
            // Unstable algorithm (No gaurantee that the relative positioning
            // of duplicate items will be preserved)
            // Better than merge sort most of the time

            int[] intArray = { 20, 35, -15, 7, 55, 1, -22 };

            QuickSort(intArray, 0, intArray.Length);

            Console.WriteLine(string.Join(" ", intArray));
            Console.ReadLine();
        }

        public static void QuickSort(int[] input, int start, int end)
        {
            if (end - start < 2) // Its mean we are dealing with one element array
            {
                return;
            }
            // Find out the pivot 
            int pivotIndex = Partition(input, start, end);
            QuickSort(input, start, pivotIndex); // repeat the process for left side of the array
            QuickSort(input, pivotIndex + 1, end);// repeat the process for right side of the array
        }

        public static int Partition(int[] input, int start, int end)
        {
            // This is using the first element as the pivot
            int pivot = input[start];
            int i = start; 
            int j = end; // Array.length = 7, so --j not j-- next use

            while (i < j)
            {
                // Empty loop body
                // Decrement j until its equal to i or until find an element is less than the pivot
                while (i < j && input[--j] >= pivot);
                // if i still less than j, thats mean we find an element less than the pivot
                if (i < j)  
                {
                    // Move the element we find to the left of the pivot
                    input[i] = input[j];
                }

                // Empty loop body
                // Increment i until its equal to j or until find an element is greater than the pivot
                while (i < j && input[++i] <= pivot);
                // if i still less than j, thats mean we find an element greater than the pivot
                if (i < j)
                {
                    // Move the element we find to the right of the pivot
                    input[j] = input[i];
                }
            }

            input[j] = pivot;
            return j;
        }
    }
}
