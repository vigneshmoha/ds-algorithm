namespace ds.algorithms.csharp.Algorithms.Sorting
{
    public static class SelectionSort
    {
        // Select the minimum value and move it to begining of the array
        public static int[] Sort(int[] inputArray)
        {
            for(int i = 0; i < inputArray.Length; i++)
            {
                var min = i;
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if(inputArray[min] > inputArray[j])
                    {
                        // update the min array index
                        min = j;
                    }
                }

                swap(ref inputArray[i], ref inputArray[min]);
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
