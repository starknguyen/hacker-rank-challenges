using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Code30Days
{
    public class TwoDimArrayHourGlass
    {
        private int getSumAllElementsIn(List<int> elements)
        {
            int sum = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                sum += elements[i];
            }

            return sum;
        }

        public int GetMaxHourGlassSum(int[][] arr)
        {
            var hgL = new List<int>();
            var hourGlassSums = new List<int>(); // list of all sums

            int zeroIdx = 0;
            int firstIdx = 1;
            int secondIdx = 2;

            int shiftRight = 0;
            int shiftBottom = 0;

            for (int row = 0; row < arr.Length; row++)
            {
                if (shiftBottom >= 4)
                    return hourGlassSums.Max();

                if (shiftRight >= 4)
                {
                    shiftBottom += 1;
                    shiftRight = 0;
                    row += shiftBottom;
                }

                if (row == zeroIdx + shiftBottom)
                {
                    hgL.AddRange(arr[row].Skip(shiftRight).Take(3));
                }
                else if (row == firstIdx + shiftBottom)
                {
                    hgL.Add(arr[row][1 + shiftRight]);
                }
                else if (row == secondIdx + shiftBottom)
                {
                    hgL.AddRange(arr[row].Skip(shiftRight).Take(3));
                    hourGlassSums.Add(getSumAllElementsIn(hgL));

                    row = -1;
                    shiftRight += 1;
                    hgL.Clear();
                }
            }

            return hourGlassSums.Max();
        }
    }
}
