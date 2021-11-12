using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.Data.NumbersAlgorithms
{
    public class FindMax
    {
        public static int FindSecondMaxNumber(int[] array)
        {
            if (array.Length < 1)
                return 0;

            int max1 = array[0];
            int max2 = array[0];

            for(int i=0; i<array.Length; i++)
            {
                if (array[i] > max1)
                {
                    max2 = max1;
                    max1 = array[i];
                }

                if (array[i] > max2 && array[i] != max1)
                    max2 = array[i];
            }

            return max2;
        }
    }
}
