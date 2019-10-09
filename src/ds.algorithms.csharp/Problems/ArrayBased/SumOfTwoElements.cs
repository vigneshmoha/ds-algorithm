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

                if(hashMap.ContainsKey(next))
                {
                    output[0] = hashMap[next];
                    output[1] = i;
                } else
                {
                    hashMap[inputArray[i]] = i;
                }
            }

            return output;
        }
    }
}
