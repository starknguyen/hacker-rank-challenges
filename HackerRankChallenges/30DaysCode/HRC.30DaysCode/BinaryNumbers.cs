using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Code30Days
{
    /// <summary>
    /// Given a base-10 integer, n, convert it to binary (base-1). 
    /// Then find and print the base-10 integer denoting the maximum number of consecutive 1's in n's binary representation.
    /// </summary>
    public class BinaryNumbers
    {
        public int GetMaxNumberOfOne(int n)
        {
            // TEST CASE: 439
            string nBinary = Convert.ToString(n, 2);
            int countOne = 0;
            int maxTemp = 0;
            for (int i = 0; i < nBinary.Length; i++)
            {
                if (nBinary[i] == '0')
                {
                    if (countOne > maxTemp)
                    {
                        maxTemp = countOne;
                    }

                    countOne = 0;
                }
                else
                    countOne++;
            }

            return (countOne > maxTemp) ? countOne : maxTemp;
        }
    }
}
