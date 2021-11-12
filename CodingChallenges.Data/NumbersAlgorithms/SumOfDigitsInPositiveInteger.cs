using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.Data.NumbersAlgorithms
{
    public class SumOfDigitsInPositiveInteger
    {
        public static int FindSumOfDigits(int number)
        {
            if (number < 1)
                return 0;
            int sum = 0;

            while(number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        public static int FindSumOfDigitsDifferentApproach(int number)
        {
            if (number < 1)
                return 0;

            var digits = number.ToString();
            int sum = 0;

            foreach (char digit in digits)
                sum += Convert.ToInt32(digit.ToString());

            return sum;
        }
    }
}
