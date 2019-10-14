using System;
using System.Collections.Generic;
using System.Text;

namespace ds.algorithms.csharp.Problems.ArrayBased
{
    public static class TrappingRainWater
    {
        public static int GetTrappedRainWater(int[] inputArray)
        {
            int[] left_max = new int[inputArray.Length];
            int[] right_max = new int[inputArray.Length];

            left_max[0] = inputArray[0];
            for(int i=1; i<inputArray.Length;i++)
            {
                left_max[i] = Math.Max(left_max[i - 1], inputArray[i]);
            }

            right_max[inputArray.Length - 1] = inputArray[inputArray.Length - 1];
            for(int j=inputArray.Length-2; j >= 0; j--)
            {
                right_max[j] = Math.Max(right_max[j + 1], inputArray[j]);
            }

            int water = 0;

            for(int i=0;i<inputArray.Length; i++)
            {
                water += Math.Min(left_max[i], right_max[i]) - inputArray[i];
            }

            return water;
        }

        public static int GetTrappedRainWaterOptimized(int[] inputArray)
        {
            int water = 0;
            int left = 0;
            int right = inputArray.Length - 1;

            int left_max = 0;
            int right_max = 0;

            while(left <= right)
            {
                if(inputArray[left] < inputArray[right])
                {
                    if(inputArray[left] > left_max)
                    {
                        left_max = inputArray[left];
                    } else
                    {
                        water += left_max - inputArray[left];
                    }
                    left++;
                } else
                {
                    if(inputArray[right] > right_max)
                    {
                        right_max = inputArray[right];
                    } else
                    {
                        water += right_max - inputArray[right];
                    }
                    right--;
                }
            }

            return water;
        }
    }
}
