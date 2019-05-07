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
                //testTimeConversion();

                testKangarooProblem();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR - " + ex);
            }

            Console.ReadKey();
        }

        private static void testKangarooProblem()
        {
            string[] x1V1X2V2 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(x1V1X2V2[0]);
            int v1 = Convert.ToInt32(x1V1X2V2[1]);
            int x2 = Convert.ToInt32(x1V1X2V2[2]);
            int v2 = Convert.ToInt32(x1V1X2V2[3]);
            string result = kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);
        }


        // Complete the kangaroo function below.
        static string kangaroo(int x1, int v1, int x2, int v2)
        { 
            // N is positive, (x2 - x1) is positive hence (v1 - v2) MUSE BE POSITIVE
            if (v1 <= v2)
                return "NO";

            // Solve this simple equation:
            // x1 + Nv1 = x2 + Nv2
            // where N is number of steps, N MUST BE AN INTEGER
            if ((x2 - x1) / (v1 - v2) > 0 && (x2 - x1) % (v1 - v2) == 0)
                return "YES";
            else
                return "NO";
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
