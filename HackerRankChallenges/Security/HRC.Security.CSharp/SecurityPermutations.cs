using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Security.CSharp
{
    public class SecurityPermutations
    {
        public int[] GetPermutationValues(int[] input)
        {
            var inputList = input.ToList();
            var outputList = new List<int>(inputList.Count);
            for (int i = 1; i <= input.Length; i++)
            {
                outputList.Add(inputList[inputList[i - 1] - 1]);
            }

            return outputList.ToArray();
        }
    }
}
