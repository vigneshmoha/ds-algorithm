using System;
using System.Collections.Generic;
using System.Text;

namespace ds.algorithms.csharp.Algorithms.Sorting
{
    // Iterate and sort each element like how a human brain does :)
    public static class InsertionSort
    {
        public static int[] Sort(int[] inputArray)
        {
            for(int i = 1; i < inputArray.Length; i++)
            {
                int j = i - 1;
                int current = inputArray[i];

                while(j >= 0 && inputArray[j] > current)
                {
                    inputArray[j + 1] = inputArray[j];
                    j--;
                }

                inputArray[j + 1] = current;
            }

            return inputArray;
        }
    }
}
