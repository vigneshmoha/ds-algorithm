using ds.algorithms.csharp.Problems.ArrayBased;
using System;

namespace ds.algorithms.consoletest
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = new int[] { 3, 0, 0, 2, 0, 4 };
            Console.WriteLine(TrappingRainWater.GetTrappedRainWaterOptimized(inputArray));
            Console.ReadLine();
        }
    }
}
