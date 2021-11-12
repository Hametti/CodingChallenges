using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.Data.NumbersAlgorithms
{
    public class PrimeNumber
    {
        public static bool IsPrimeNumber(int number)
        {
            if (number < 2)
                return false;

            for (int i = 3; i < number - 1; i++)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
