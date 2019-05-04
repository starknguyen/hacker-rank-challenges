using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.InterviewKit.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                testSockMerchant();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex);
            }
        }


        private static void testSockMerchant()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            var sm = new SockMerchant();
            int result = sm.sockMerchant(n, ar);
        }
    }
}
