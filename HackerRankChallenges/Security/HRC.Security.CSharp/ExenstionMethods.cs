using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Security.CSharp
{
    public static class ExenstionMethods
    {
        public static int[] GetInputsWithSpaceSeparated()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] inputs = Console.ReadLine().Split(' ')
                                             .Select(s => Convert.ToInt32(s))
                                             .ToArray();
            return inputs;
        }
    }
}
