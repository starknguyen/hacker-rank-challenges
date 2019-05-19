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
                //testAppleOrangesProblem();
                //testBirthdayBarProblem();
                //testRussianCalendar();
                //testBonAppetitProblem();
                //testBreakingRecordsProblem();
                //testPickingNumbersProblem();
                //testDivisibleSumPairs();
                //testBeautifulTriplets();
                //testSimpleDesignPdfViewer();
                //testMigratoryBirds();
                //testUtopianTree();
                //testMoneySpent();
                //testAngryProfessor();
                //testViralAdvertising();
                //testBeautifulDays();

                testPermutationEquation();

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR - " + ex);
            }

            Console.ReadKey();
        }


        private static void testPermutationEquation()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp));
            int[] result = permutationEquation(p);

            Console.WriteLine(string.Join("\n", result));
        }


        // Complete the permutationEquation function below.
        static int[] permutationEquation(int[] p)
        {
            Dictionary<int, int> p1 = new Dictionary<int, int>();
            for (int i = 0; i < p.Length; i++)
            {
                p1.Add(p[i], i + 1);
            }
            Dictionary<int, int> p2 = new Dictionary<int, int>();
            for (int i = 0; i < p1.Count; i++)
            {
                p2.Add(p[i], p1[i + 1]);
            }

            var permList = new List<int>();
            for (int i = 0; i < p1.Count; i++)
            {
                permList.Add(p1[p2.ElementAt(i).Value]);
            }

            return permList.ToArray();
        }


        private static void testBeautifulDays()
        {
            string[] ijk = Console.ReadLine().Split(' ');
            int i = Convert.ToInt32(ijk[0]);
            int j = Convert.ToInt32(ijk[1]);
            int k = Convert.ToInt32(ijk[2]);

            int result = beautifulDays(i, j, k);

            Console.WriteLine(result);
        }


        // Complete the beautifulDays function below.
        static int beautifulDays(int i, int j, int k)
        {
            int count = 0;
            for (int n = i; n <= j; n++)
            {
                int reversed = Int32.Parse(new String(n.ToString().Reverse().ToArray()));
                if (Math.Abs(n - reversed) % k == 0)
                    count++;
            }

            return count;
        }


        private static void testViralAdvertising()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = viralAdvertising(n);

            Console.WriteLine(result);
        }


        // Complete the viralAdvertising function below.
        static int viralAdvertising(int n)
        {
            int initialNumPeople = 5;
            int numLike = 0;
            for (int i = 0; i < n; i++)
            {
                numLike += (int)Math.Floor(initialNumPeople / 2.0);
                initialNumPeople = (int)Math.Floor((initialNumPeople / 2.0)) * 3;
            }

            return numLike;
        }

        private static void testAngryProfessor()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(nk[0]);
                int k = Convert.ToInt32(nk[1]);
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
                string result = angryProfessor(k, a);

                Console.WriteLine(result);
            }
        }


        // Complete the angryProfessor function below.
        static string angryProfessor(int k, int[] a)
        {
            var students = a.ToList();
            var numStudentsOnTime = students.Where(s => s <= 0).Count();
            if (numStudentsOnTime < k)
                return "YES";
            else
                return "NO";
        }


        private static void testMoneySpent()
        {
            string[] bnm = Console.ReadLine().Split(' ');
            int b = Convert.ToInt32(bnm[0]);
            int n = Convert.ToInt32(bnm[1]);
            int m = Convert.ToInt32(bnm[2]);
            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));
            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = getMoneySpent(keyboards, drives, b);

            Console.WriteLine(moneySpent);
        }   


        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            /*
             * Write your code here.
             */
            int max = -1;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    if (keyboards[i] + drives[j] <= b && keyboards[i] + drives[j] > max)
                        max = keyboards[i] + drives[j];
                }
            }

            return max;
        }


        static int pageCount(int n, int p)
        {
            /*
             * Write your code here.
             */

            return new List<int>() { p / 2, (n / 2 - p / 2) }.Min();
        }


        private static void testUtopianTree()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = utopianTree(n);

                Console.WriteLine(result);
            }
        }


        // Complete the utopianTree function below.
        static int utopianTree(int n)
        {
            if (n == 0)
                return 1;
            if (n % 2 == 0)
            {
                // Summer = +1
                return 1 + utopianTree(n - 1);                
            }
            else
            {
                // Spring = x2
                return 2 * utopianTree(n - 1);
            }
        }


        private static void testMigratoryBirds()
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            int result = migratoryBirds(arr);

            Console.WriteLine(result);
        }


        // Complete the migratoryBirds function below.
        static int migratoryBirds(List<int> arr)
        {
            var grouped = arr.GroupBy(i => i)
                             .OrderByDescending(g => g.Count()).ToList();
            var maxGroup = grouped.Max(g => g.Count());
            var sortGroup = grouped.Where(g => g.Count() == maxGroup);

            return sortGroup.Min(g => g.Key);
        }


        private static void testSimpleDesignPdfViewer()
        {
            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);

            Console.WriteLine(result);
        }


        // Complete the designerPdfViewer function below.
        static int designerPdfViewer(int[] h, string word)
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();            
            Dictionary<char, int> chHeightMap = new Dictionary<char, int>();
            for (int i = 0; i < h.Length; i++)
            {
                chHeightMap.Add(alpha[i], h[i]);
            }

            int maxHeight = 0;
            foreach (char c in word)
            {
                if (chHeightMap[c] > maxHeight)
                    maxHeight = chHeightMap[c];
            }

            return maxHeight * word.Length;
        }


        private static void testBeautifulTriplets()
        {
            string[] nd = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nd[0]);
            int d = Convert.ToInt32(nd[1]);
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int result = beautifulTriplets(d, arr);

            Console.WriteLine(result);
        }


        // Complete the beautifulTriplets function below.
        static int beautifulTriplets(int d, int[] arr)
        {
            int count = 0;
            List<int> arrList = arr.ToList();
            bool isTake = true;
            for (int i = 0; i < arr.Length; i++)
            {
                int prevIdx = i;
                int currIdx = i;
                int findNum = 0;
                while ((findNum = arr[currIdx] + d) <= (arr[i] + 2 * d))
                {
                    currIdx = arrList.IndexOf(findNum);
                    if (currIdx < prevIdx)
                    {
                        isTake = false;
                        break;
                    }
                    prevIdx = currIdx;
                    isTake = true;
                }

                if (isTake)
                    count++;
            }                   

            return count;
        }


        private static void testDivisibleSumPairs()
        {
            string[] nk = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = divisibleSumPairs(n, k, ar);

            Console.WriteLine(result);
        }


        // Complete the divisibleSumPairs function below.
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }


        private static void testPickingNumbersProblem()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = pickingNumbers(a);

            Console.WriteLine(result);
        }


        static int pickingNumbers(List<int> a)
        {
            int higher1 = 0, lower1 = 0;
            List<int> retval = new List<int>();

            for (int i = 0; i < a.Count(); i++)
            {
                lower1 = Math.Abs(1 - a[i]);
                higher1 = 1 + a[i];
                var findLower1 = a.Where(ai => ai == lower1).Count() + 1; // + lower
                var findHigher1 = a.Where(ai => ai == higher1).Count() + 1; // + higher
                var equalValues = a.Where(ai => ai == a[i]).Count() - 1;
                int tempMax = (findLower1 > findHigher1) ? findLower1 : findHigher1;
                retval.Add(tempMax + equalValues);
            }

            return retval.Max();
        }


        private static void testBreakingRecordsProblem()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            int[] result = breakingRecords(scores);

            Console.WriteLine(string.Join(" ", result));
        }


        // Complete the breakingRecords function below.
        static int[] breakingRecords(int[] scores)
        {
            int breakHighCount = 0;
            int breakLowCount = 0;
            int tempHigh = scores[0], tempLow = scores[0];

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > tempHigh)
                {
                    tempHigh = scores[i];
                    breakHighCount++;
                    continue;
                }
                if (scores[i] < tempLow)
                {
                    tempLow = scores[i];
                    breakLowCount++;
                    continue;
                }
            }

            return new int[] { breakHighCount, breakLowCount };
        }


        private static void testBonAppetitProblem()
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);
            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();
            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);
        }


        // Complete the bonAppetit function below.
        static void bonAppetit(List<int> bill, int k, int b)
        {
            int expectedSum = 0;
            for (int i = 0; i < bill.Count(); i++)
            {
                if (i == k)
                    continue;
                expectedSum += bill[i];
            }

            expectedSum /= 2;

            if (expectedSum == b)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(b - expectedSum);
        }


        private static void testRussianCalendar()
        {
            int year = Convert.ToInt32(Console.ReadLine().Trim());
            string result = dayOfProgrammer(year);

            Console.WriteLine(result);
        }


        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            int febDays = 28;
            if (year >= 1700 && year <= 1917)
            {
                // Julian calendar
                if (year % 4 == 0)
                {
                    febDays = 29;
                }
            }
            else if (year == 1918)
            {
                return "26.09.1918";
            }
            else
            {
                // After 1918, Gregorian calendar
                if (year % 400 == 0 ||
                    year % 4 == 0 && year % 100 != 0)
                {
                    febDays = 29;
                }
            }

            int totalDaysBeforeOctober = 31 * 5 + 30 * 3 + febDays;
            int dayProg = 30 - (totalDaysBeforeOctober - 256);

            return $"{dayProg:D2}.09.{year}";
        }


        private static void testBirthdayBarProblem()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
            string[] dm = Console.ReadLine().TrimEnd().Split(' ');
            int d = Convert.ToInt32(dm[0]);
            int m = Convert.ToInt32(dm[1]);
            int result = birthday(s, d, m);

            Console.WriteLine(result);
        }


        // Complete the birthday function below.
        static int birthday(List<int> s, int d, int m)
        {
            if (m == 1 && s.First() != d)
                return 0;
            bool isSameValuesAll = !s.Any(si => si != s[0]);
            int a = 31 / s.First();
            if (isSameValuesAll && a < m)
                return 0;

            int solutionCount = 0;
            int tempSum = 0;
            int shiftCount = 0;
            for (int i = 0; i < s.Count(); i++)
            {               
                if (i == 0)
                {
                    for (int j = 0; j < m; j++)
                    {
                        tempSum += s[j];
                    }
                }
                else
                {
                    shiftCount++;
                    int idx = i + m - 1;
                    if (idx >= s.Count())
                        return solutionCount;
                    tempSum += s[idx];
                }

                if (tempSum == d)
                {
                    solutionCount++;
                }
                // Remove first element in the whole slice before shifting
                tempSum -= s[shiftCount];
            }

            return solutionCount;
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
