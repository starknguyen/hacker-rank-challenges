using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.InterviewKit.CSharp
{
    public class SockMerchant
    {
        // Complete the sockMerchant function below.
        public int sockMerchant(int n, int[] ar)
        {
            int pairCount = 0;
            List<int> arList = ar.ToList();
            List<int> disctinctList = ar.Distinct().ToList();
            
            for (int i = 0; i < disctinctList.Count(); i++)
            {
                int count = arList.Where(s => s == disctinctList[i]).Count();
                pairCount += (count / 2);
            }

            return pairCount;
        }        
    }
}
