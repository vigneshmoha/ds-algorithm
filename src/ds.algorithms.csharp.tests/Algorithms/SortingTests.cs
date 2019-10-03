using ds.algorithms.csharp.Algorithms.Sorting;
using System.Collections.Generic;
using Xunit;

namespace ds.algorithms.csharp.tests.Algorithms
{
    public class SortingTests
    {

        [Theory]
        [MemberData(nameof(Data))]
        public void BubbleSort_SortData_and_Assert(int[] inputArray, int[] expectedArray)
        {
            var outputArray = BubbleSort.Sort(inputArray);
            Assert.Equal(expectedArray, outputArray);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void SelectionSort_SortData_and_Assert(int[] inputArray, int[] expectedArray)
        {
            var outputArray = SelectionSort.Sort(inputArray);
            Assert.Equal(expectedArray, outputArray);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void HeapSort_SortData_and_Assert(int[] inputArray, int[] expectedArray)
        {
            var outputArray = SelectionSort.Sort(inputArray);
            Assert.Equal(expectedArray, outputArray);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void InsertionSort_SortData_and_Assert(int[] inputArray, int[] expectedArray)
        {
            var outputArray = InsertionSort.Sort(inputArray);
            Assert.Equal(expectedArray, outputArray);
        }

        public static TheoryData<int[], int[]> Data =>
            new TheoryData<int[], int[]>
            {
                { new int[] {4,3,2}, new int[] {2,3,4}},
                { new int[] {7,8,4,9,2,4}, new int[] {2,4,4,7,8,9}},
                { new int[] {0,1,9,8,7,5,2,6,4,3}, new int[] {0,1,2,3,4,5,6,7,8,9}},
                { new int[] {9999999, 847859, 647485}, new int[] {647485, 847859, 9999999}}
            };
    }
}
