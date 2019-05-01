using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.DataStructures.CSharp
{
    public class SparseArrays
    {
        public int[] MatchingStrings(string[] strings, string[] queries)
        {
            var stringList = strings.ToList();
            var queriesList = queries.ToList();
            var matchStrCountList = new List<int>();

            queriesList.ForEach(q =>
            {
                matchStrCountList.Add(stringList.Where(s => String.Equals(q, s)).Count());
            });

            return matchStrCountList.ToArray();
        }
    }
}
