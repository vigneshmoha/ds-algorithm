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
        [InlineData(new int[] { 2, 7, 8, 5 }, 10, new int[] {0, 2})]
        public static void ArrayBased_SumOfTwoElements_PositiveScenarios(int[] inputArray, int target, int[] expectedArray)
        {
            var outputArray = SumOfTwoElements.GetIndexOfElements(inputArray, target);

            Assert.Equal(expectedArray, outputArray);
        }
    }
}
