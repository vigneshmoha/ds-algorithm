using System;
using System.Collections.Generic;
using System.Text;

namespace ds.algorithms.csharp.Algorithms.Sorting
{
    public static class HeapSort
    {
        // Sorting technique on Binary heap
        // Similar to Selection sort where we find the maximum element and place at the end of the array
        public static int[] Sort(int[] inputArray)
        {
            var n = inputArray.Length;
            for(int i = n/2 -1; i >= 0; i--)
            {
                Heapfify(inputArray, n, i);
            }

            for(int i = n - 1; i >= 0; i--)
            {
                // Swap to from beginning to end
                int temp = inputArray[0];
                inputArray[0] = inputArray[1];
                inputArray[1] = temp;

                Heapfify(inputArray, i, 0);
            }

            return inputArray;
        }

        private static void Heapfify(int[] array, int size, int maxHeap)
        {
            int max = maxHeap;
            int left = 2 * max + 1;
            int right = 2 * max + 2;

            if(left < size && array[left] > array[max])
            {
                max = left;
            }

            if(right < size && array[right] > array[max])
            {
                max = right;
            }

            if(max != maxHeap)
            {
                int temp = array[maxHeap];
                array[maxHeap] = array[max];
                array[max] = temp;

                Heapfify(array, size, max);
            }
        }
    }
}
