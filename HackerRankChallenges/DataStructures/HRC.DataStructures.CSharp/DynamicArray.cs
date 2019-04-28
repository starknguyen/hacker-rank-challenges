using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.DataStructures.CSharp
{
    public class DynamicArray
    {
        private uint _numberOfQuery;
        private uint _numberOfSeq;

        private List<List<int>> _sequences;

        public DynamicArray(int numberOfSeq, int numberOfQuery)
        {
            // TODO: add constraints here?

            _numberOfSeq = (uint)numberOfSeq;
            _numberOfQuery = (uint)numberOfQuery;

            _sequences = new List<List<int>>();
            for (int i = 0; i < _numberOfSeq; i++)
            {
                _sequences.Add(new List<int>()); 
            }
        }


        public uint LastAnswer { get; private set; }


        public void ExecuteQuery(string query)
        {
            var querySplit = query.Split(' ').ToList().Select(s => Convert.ToInt32(s)).ToList();

            int idx = (int)(((uint)querySplit[1] ^ LastAnswer) % _numberOfSeq);

            if (querySplit.First() == 1)
            {
                // Append integer y to seq idx x
                _sequences[idx].Add(querySplit[2]);
            }
            else if (querySplit.First() == 2)
            {
                int idxToFind = querySplit[2] % (_sequences[idx].Count);
                LastAnswer = (uint)_sequences[idx][idxToFind];
                Console.WriteLine(LastAnswer);
            }
            else
            {
                throw new Exception("Unsupported query type");
            }
        }



    }
}
