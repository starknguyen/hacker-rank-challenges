using HRC.Algorithm.CSharp.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Algorithm.CSharp
{
    public class MiniMaxSum
    {
        public void PrintResult(int[] inputs)
        {
            // Sort input arr
            var quickSort = new QuickSort();
            quickSort.Sort(inputs, 0, inputs.Length - 1);
            
            uint minSum = 0;
            uint maxSum = 0;
            // Calculate minimum sum from sorted arr
            inputs.Take(inputs.Length - 1).ToList().ForEach(i => minSum += (uint)i);
            // Calculate maximum sum from sorted arr
            inputs.ToList().GetRange(1, inputs.Length - 1).ForEach(i => maxSum += (uint)i);

            // Print
            Console.WriteLine($"{minSum} {maxSum}");
        }
    }
}
