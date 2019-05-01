using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ext = HRC.Security.CSharp.ExenstionMethods;

namespace HRC.Security.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //testInverseFunction();

                testSecurityPermutations();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR - " + ex);
            }

            Console.ReadKey();         
        }


        private static void testSecurityPermutations()
        {
            int[] inputs = ext.GetInputsWithSpaceSeparated();
            var sp = new SecurityPermutations();
            var retval = sp.GetPermutationValues(inputs);
            retval.ToList().ForEach(v => Console.WriteLine($"{v} "));
        }


        private static void testInverseFunction()
        {
            int[] inputs = ext.GetInputsWithSpaceSeparated();

            InverseFunction iv = new InverseFunction();
            var inversed = iv.GetInverseFunctionValues(inputs);
        }

    }
}
