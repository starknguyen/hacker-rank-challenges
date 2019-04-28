using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Code30Days
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                testBinaryNumbers();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR - " + ex);
            }

            Console.ReadKey();
        }


        private static void testBinaryNumbers()
        {
            var input = Convert.ToInt32(Console.ReadLine());

            var bn = new BinaryNumbers();
            var result = bn.GetMaxNumberOfOne(input);
            Console.WriteLine(result);
        }
    }
}
