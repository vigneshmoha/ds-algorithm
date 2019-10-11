using System;
using System.Collections.Generic;
using System.Text;

namespace ds.algorithms.csharp.Problems.ArrayBased
{
    public static class ContainerWithMostWater
    {
        public static int FindMaxArea(int[] inputArray)
        {
            int maxArea = 0;
            int leftPointer = 0;
            int rightPointer = inputArray.Length - 1;

            while(leftPointer < rightPointer)
            {
                // calculate max area with current pointer values and retain the max value in max area
                maxArea = Math.Max(maxArea, Math.Min(inputArray[leftPointer], inputArray[rightPointer]) * (rightPointer - leftPointer));

                if(inputArray[leftPointer] < inputArray[rightPointer])
                {
                    leftPointer++;
                } else
                {
                    rightPointer--;
                }
            }

            return maxArea;
        }
    }
}
