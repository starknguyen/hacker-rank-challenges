using HRC.Contests.CSharp.HourRank31;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Contests.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            testPosterHangProblem();
        }


        private static void testPosterHangProblem()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int h = Convert.ToInt32(firstMultipleInput[1]);
            List<int> wallPoints = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(wallPointsTemp => Convert.ToInt32(wallPointsTemp)).ToList();
            List<int> lengths = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(lengthsTemp => Convert.ToInt32(lengthsTemp)).ToList();

            var postetHand = new PosterHang();
            int answer = postetHand.solve(h, wallPoints, lengths);
        }

    }
}
