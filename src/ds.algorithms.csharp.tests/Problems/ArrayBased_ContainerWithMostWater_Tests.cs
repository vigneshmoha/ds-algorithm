using ds.algorithms.csharp.Problems.ArrayBased;
using Xunit;

namespace ds.algorithms.csharp.tests.Problems
{
    public static class ArrayBased_ContainerWithMostWater_Tests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public static void ArrayBased_ContainerWithMostWater_GetMaxAreaValues(int[] inputArray, int expectedMaxArea)
        {
            var outputMaxArea = ContainerWithMostWater.FindMaxArea(inputArray);
            Assert.Equal(expectedMaxArea, outputMaxArea);
        }

        public static TheoryData<int[], int> Data =>
            new TheoryData<int[], int>() {
                { new int[] { 1,5,4,3 },  6 },
                { new int[] {},  0 },
                { new int[] { 3, 1, 2, 4, 5 }, 12 }
            };
    }
}
