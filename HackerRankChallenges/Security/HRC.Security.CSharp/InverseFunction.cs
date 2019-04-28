using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Security.CSharp
{
    public class InverseFunction
    {
        public int[] GetInverseFunctionValues(int[] inputsArr)
        {
            int[] inversedValues = new int[inputsArr.Length];

            for (int i = 1; i <= inputsArr.Length; i++)
            {
                // start from idx 0
                inversedValues[i - 1] = inputsArr.ToList().IndexOf(i) + 1;
                Console.WriteLine(inversedValues[i - 1]);
            }

            return inversedValues;
        }
    }
}
