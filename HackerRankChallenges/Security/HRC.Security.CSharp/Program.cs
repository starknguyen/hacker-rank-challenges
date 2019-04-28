using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Security.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] inputs = getInputsWithSpaceSeparated();

                InverseFunction iv = new InverseFunction();
                var inversed = iv.GetInverseFunctionValues(inputs);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR - " + ex);
            }

            Console.ReadKey();         
        }


        private static int[] getInputsWithSpaceSeparated()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] inputs = Console.ReadLine().Split(' ')
                                             .Select(s => Convert.ToInt32(s))
                                             .ToArray();
            return inputs;
        }
    }
}
