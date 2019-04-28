﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.DataStructures.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                testDynamicArray();
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


        private static void testDynamicArray()
        {
            string[] nq = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(nq[0]);
            int q = Convert.ToInt32(nq[1]);

            var dynamicArr = new DynamicArray(n, q);

            //List<string> queries = new List<string>();
            List<List<int>> queries = new List<List<int>>();
            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
                //queries.Add(Console.ReadLine().TrimEnd());
                // Execute query
                //dynamicArr.ExecuteQuery(queries.Last());
            }

            var results = dynamicArray(n, queries);
            results.ForEach(r => Console.Write($"{r} "));
        }


        static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            var sequences = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                sequences.Add(new List<int>());
            }

            int LastAnswer = 0;
            List<int> results = new List<int>();

            queries.ForEach(q =>
            {
                int idx = (int)(((uint)q[1] ^ LastAnswer) % n);

                if (q.First() == 1)
                {
                    // Append integer y to seq idx x
                    sequences[idx].Add(q[2]);
                }
                else if (q.First() == 2)
                {
                    int idxToFind = q[2] % (sequences[idx].Count);
                    LastAnswer = sequences[idx][idxToFind];
                    results.Add(LastAnswer);
                }
                else
                {
                    throw new Exception("Unsupported query type");
                }
            });

            return results;
        }
    }
}
