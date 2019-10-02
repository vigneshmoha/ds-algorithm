using System;
using System.Collections.Generic;
using System.Text;

namespace ds.algorithms.csharp.Algorithms.Sorting
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] inputArray)
        {
            for(int i = 0; i < inputArray.Length - 1; i++)
            {
                for(int j = 0; j < inputArray.Length - i - 1; j++)
                {
                    if(inputArray[j] > inputArray[j + 1])
                    {
                        swap(ref inputArray[j], ref inputArray[j + 1]);
                    }
                }
            }
            return inputArray;
        }

        private static void swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
