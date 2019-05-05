using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Code30Days
{
    public class PrimeOptimization
    {
        public bool IsPrime(int number)
        {
            // Reference implementation: https://stackoverflow.com/a/44016357/4329813

            if (number <= 1)
                return false;
            if (number <= 3)
                return true;
            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i*i <= number; i += 6)
            {
                if (number % i == 0)
                    return false;
                if (number % (i + 2) == 0)
                    return false;
            }

            return true;
        }
    }
}
