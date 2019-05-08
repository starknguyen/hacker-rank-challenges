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
                //testKangarooProblem();
                //testBetweenSetsProblem();

                testAppleOrangesProblem();

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR - " + ex);
            }

            Console.ReadKey();
        }


        private static void testAppleOrangesProblem()
        {
            string[] st = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(st[0]);
            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(ab[0]);
            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(mn[0]);
            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));
            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }


        // Complete the countApplesAndOranges function below.
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            List<int> applesFinalDistances = new List<int>();
            List<int> orangesFinalDistances = new List<int>();

            for (int i = 0; i < apples.Length; i++)
            {
                applesFinalDistances.Add(apples[i] + a);
            }

            for (int i = 0; i < oranges.Length; i++)
            {
                orangesFinalDistances.Add(oranges[i] + b);
            }

            int nAppleInHouse = applesFinalDistances.Where(d => d >= s && d <= t).Count();
            Console.WriteLine(nAppleInHouse);
            int nOrangeInHouse = orangesFinalDistances.Where(d => d >= s && d <= t).Count(); Console.WriteLine(nOrangeInHouse);
        }


        private static void testBetweenSetsProblem()
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nm[0]);
            int m = Convert.ToInt32(nm[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp));

            int total = getTotalX(a, b);
            Console.WriteLine(total);
        }


        /*
        * Complete the getTotalX function below.
        */
        static int getTotalX(int[] a, int[] b)
        {
            /*
             * Write your code here.
             */
            // Make sure that both array were sorted
            var aList = a.ToList();
            aList.Sort();
            var bList = b.ToList();
            bList.Sort();

            // (product of all ai) <= m <= b1
            int retval = 0;
            List<int> factorB = new List<int>();

            int aLCM = LCM(a);
            List<int> availableValues = new List<int>();
            for (int i = aLCM; i <= bList.First();/*; i += aLCM*/)
            {
                availableValues.Add(i);
                int incr = i + aLCM;
                if (incr > bList.First())
                    break;
                i = incr;
            }

            for (int i = 0; i < availableValues.Count(); i++)
            {
                bool take = false;
                for (int k = 0; k < b.Length; k++)
                {
                    if (b[k] % availableValues[i] == 0)
                        take = true;
                    else
                    {
                        take = false;
                        break; // we don't have to care anymore
                    }
                }
                if (take)
                    factorB.Add(availableValues[i]);
            }

            retval = factorB.Distinct().Count();

            return retval;
        }

        static int GCD(int[] numbers)
        {
            return numbers.Aggregate(GCD);
        }

        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        static int LCM(int[] numbers)
        {
            return numbers.Aggregate(lcm);
        }
        static int lcm(int a, int b)
        {
            return Math.Abs(a * b) / GCD(a, b);
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
            // N is positive, (x2 - x1) is positive hence (v1 - v2) MUST BE POSITIVE
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
