using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.Data.ArrayChallenges
{
    public class Converting
    {
        public static int[] ConvertTwoDimensionalToOneDimensional(int[,] array, int row, int column)
        {
            var result = new int[array.Length];
            int index = 0;

            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                {
                    result[index] = array[i, j];
                    index++;
                }

            return result;
        }
    }
}
