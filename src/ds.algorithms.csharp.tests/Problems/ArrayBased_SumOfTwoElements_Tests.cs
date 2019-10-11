using ds.algorithms.csharp.Problems.ArrayBased;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ds.algorithms.csharp.tests.Problems
{
    public class ArrayBased_SumOfTwoElements_Tests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public static void ArrayBased_SumOfTwoElements_PositiveScenarios(int[] inputArray, int target, int[] expectedArray, bool exists)
        {
            var outputArray = SumOfTwoElements.GetIndexOfElements(inputArray, target);

            Assert.Equal(expectedArray, outputArray);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public static void ArrayBased_SumOfTwoElements_CheckIfEleExists(int[] inputArray, int target, int[] expectedArray, bool exists)
        {
            var isExists = SumOfTwoElements.ElementWithSumExists(inputArray, target);
            Assert.True(isExists == exists);
        }

        public static TheoryData<int[], int, int[], bool> Data =>
            new TheoryData<int[], int, int[], bool>
            {
                { new int[] { 2, 7, 8, 5 }, 10, new int[] {0, 2}, true },
                { new int[] { 3, 10, 8, 4, 2, 1 }, 6, new int[] { 3, 4 }, true },
                { new int[] { 3, 10, 8, 4, 2, 1 }, 5, new int[] { 0, 4 }, true },
                { new int[] { 3, 10, 8, 4, 2, 1 }, 25, new int[] { 0, 0 }, false },
            };
    }
}
