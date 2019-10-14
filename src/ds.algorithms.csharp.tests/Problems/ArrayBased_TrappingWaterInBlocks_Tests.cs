using ds.algorithms.csharp.Problems.ArrayBased;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ds.algorithms.csharp.tests.Problems
{
    public class ArrayBased_TrappingWaterInBlocks_Tests
    {

        [Theory]
        [MemberData(nameof(Data))]
        public static void ArrayBased_TrappingWaterInBlocks_NonSpaceOptimized_ValidateTheResult(int[] inputArray, int expectedValue)
        {
            var actualValue = TrappingRainWater.GetTrappedRainWater(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public static void ArrayBased_TrappingWaterInBlocks_SpaceOptimized_ValidateTheResult(int[] inputArray, int expectedValue)
        {
            var actualValue = TrappingRainWater.GetTrappedRainWaterOptimized(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }

        public static TheoryData<int[], int> Data =>
            new TheoryData<int[], int>
            {
                { new int[] { 3, 10, 8, 4, 2, 1 }, 0 },
                { new int[] { 3, 0, 0, 2, 0, 4 }, 10 },
                { new int[] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1}, 6 }
            };
    }
}
