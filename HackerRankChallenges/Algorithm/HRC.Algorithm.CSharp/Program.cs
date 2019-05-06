using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Algorithm.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //testMiniMaxSum();

                testTimeConversion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR - " + ex);
            }

            Console.ReadKey();
        }

        private static void testTimeConversion()
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
        }


        /*
        * Complete the timeConversion function below.
        */
        static string timeConversion(string s)
        {
            /*
             * Write your code here.
             */
            string retval = String.Empty;
            var timeSplit = s.Substring(0, s.Length - 2).Split(':').ToList().Select(st => st.ToString()).ToList();
            int hour = Convert.ToInt32(timeSplit[0]);
            string min = timeSplit[1];
            string sec = timeSplit[2];

            if (s.EndsWith("PM"))
            {
                if (hour >= 12)
                    return s.Substring(0, s.Length - 2);
                else
                    return $"{12 + hour}:{min}:{sec}";
            }
            else
            {
                if (hour == 12)
                    return $"{12 - hour:00}:{min}:{sec}";
                else
                    return s.Substring(0, s.Length - 2);
            }
        }


        private static void testMiniMaxSum()
        {
            var inputArr = getInputsWithSpaceSeparated();

            MiniMaxSum mms = new MiniMaxSum();
            mms.PrintResult(inputArr);
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
