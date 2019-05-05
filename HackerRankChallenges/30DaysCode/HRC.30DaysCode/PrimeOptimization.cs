using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Code30Days
{
    public class PrimeOptimization
    {
        public uint BenchMarkCount { get; private set; }

        public bool IsPrime(uint number)
        {
            // Reference implementation: https://stackoverflow.com/a/44016357/4329813            
            BenchMarkCount = 0;

            if (number <= 1)
            {
                BenchMarkCount++;
                return false;
            }
            if (number <= 3)
            {
                BenchMarkCount++;
                return true;
            }

            if (number % 2 == 0 || number % 3 == 0)
            {
                BenchMarkCount++;
                return false;
            }

            for (int i = 5; i*i <= number; i += 6)
            {
                BenchMarkCount++;
                if (number % i == 0)
                    return false;
                if (number % (i + 2) == 0)
                    return false;
            }

            return true;
        }


        public bool IsPrimeOptimize1(uint number)
        {
            BenchMarkCount = 0;
            if (number == 2)
            {
                BenchMarkCount++;
                return true;
            }
            else if (number == 1 || (number & 1) == 0)
            {
                BenchMarkCount++;
                return false;
            }

            for (uint i = 3; i <= (uint)Math.Sqrt(number); i += 2)
            {
                BenchMarkCount++;
                if (number % i == 0)
                    return false;
            }

            BenchMarkCount++;
            return true;
        }
    }
}
