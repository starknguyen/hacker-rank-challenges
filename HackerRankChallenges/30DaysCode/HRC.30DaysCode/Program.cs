using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HRC.Code30Days.InheritanceProblem;

namespace HRC.Code30Days
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //testBinaryNumbers();
                //test2DArrayHourGlass();
                testInheritance();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR - " + ex);
            }

            Console.ReadKey();
        }

        private static void testInheritance()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }

        private static void test2DArrayHourGlass()
        {
            //int[][] arr = new int[6][];

            //for (int i = 0; i < 6; i++)
            //{
            //    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //}

            // SAMPLE DATA
            int[][] arr = new int[][]
            {
                    new int[] { 1, 1, 1, 0, 0, 0 },
                    new int[] { 0, 1, 0, 0, 0, 0 },
                    new int[] { 1, 1, 1, 0, 0, 0 },
                    new int[] { 0, 0, 2, 4, 4, 0 },
                    new int[] { 0, 0, 0, 2, 0, 0 },
                    new int[] { 0, 0, 1, 2, 4, 0 },
            };

            var hourGlass = new TwoDimArrayHourGlass();
            var max = hourGlass.GetMaxHourGlassSum(arr);
            Console.WriteLine(max);
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
