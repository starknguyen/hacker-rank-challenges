using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Contests.CSharp.HourRank31
{
    public class PosterHang
    {
        public int solve(int h, List<int> wallPoints, List<int> lengths)
        {
            List<KeyValuePair<int, int>> dict = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < wallPoints.Count(); i++)
                dict.Add(new KeyValuePair<int, int>(wallPoints[i], lengths[i]));

            int heightRequired = 0;

            foreach (var item in dict)
            {
                int heightToReach = item.Key - (item.Value / 4);
                if (heightToReach < 5)
                    continue;
                int temp = Convert.ToInt32(Math.Ceiling((double)heightToReach - h));
                if (temp > heightRequired)
                    heightRequired = temp;
            }

            return heightRequired;
        }
    }
}
