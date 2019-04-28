using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Code30Days
{
    public class Scope
    {
        public class Difference
        {
            private int[] elements;
            public int maximumDifference;

            // Add your code here
            public Difference(int[] arr)
            {
                elements = arr;
            }

            public void computeDifference()
            {
                System.Collections.Generic.List<int> allSums = new System.Collections.Generic.List<int>();
                int tempDiff = 0;
                int tempFirstIdx = 0;
                int tempIncrIdx = 0;
                for (int i = 0; i < elements.Length - 1; i++)
                {
                    while (tempIncrIdx < elements.Length - 1)
                    {
                        tempIncrIdx++;
                        tempDiff = Math.Abs(elements[tempFirstIdx] - elements[tempIncrIdx]);    
                        allSums.Add(tempDiff);
                    }

                    tempFirstIdx++;
                    tempIncrIdx = 0;
                }

                maximumDifference = allSums.Max();
            }

        } // End of Difference Class
    }
}
