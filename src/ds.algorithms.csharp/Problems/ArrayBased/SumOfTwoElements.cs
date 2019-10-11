using ds.algorithms.csharp.Algorithms.Sorting;
using System.Collections.Generic;

namespace ds.algorithms.csharp.Problems.ArrayBased
{
    public static class SumOfTwoElements
    {
        public static int[] GetIndexOfElements(int[] inputArray, int target)
        {
            int[] output = new int[2];
            Dictionary<int, int> hashMap = new Dictionary<int, int> {
                { inputArray[0], 0 }
            };
            for (int i=0; i<inputArray.Length; i++)
            {
                var next = target - inputArray[i];

                if(next != inputArray[i] && hashMap.ContainsKey(next))
                {
                    output[0] = hashMap[next];
                    output[1] = i;
                    return output;
                } else
                {
                    hashMap[inputArray[i]] = i;
                }
            }

            return output;
        }

        public static bool ElementWithSumExists(int[] inputArray, int target)
        {
            int[] output = new int[2];

            var leftPointer = 0;
            var rightPointer = inputArray.Length - 1;

            var sortedArray = SelectionSort.Sort(inputArray);

            while(leftPointer < rightPointer)
            {
                var sum = sortedArray[leftPointer] + sortedArray[rightPointer];
                if (sum == target)
                {
                    return true;
                }

                if(sum < target)
                {
                    leftPointer++;
                } else
                {
                    rightPointer--;
                }
            }

            return false;
        }
    }
}
