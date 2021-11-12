using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.Data.ArrayChallenges
{
    public class Rotations
    {
        public static int[] RightCircularRotation(int[] array)
        {
            if (array.Length == 0)
                return array;

            int temp = array[0];

            for(int i=0; i<array.Length - 1; i++)
            {
                temp = array[0];
                array[0] = array[i + 1];
                array[i + 1] = temp;
            }

            return array;
        }

        public static int[] RightCircularRotationByNewArray(int[] array)
        {
            if (array.Length == 0)
                return array;

            var result = new int[array.Length];

            for (int i = 0; i < array.Length-1; i++)
                result[i+1] = array[i];

            result[0] = array[array.Length - 1];

            return result;
        }

        public static int[] RightCircularRotationDifferentMethod(int[] array)
        {
            if (array.Length == 0)
                return array;

            int temp = 0;

            for(int i=0; i<array.Length; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - 1];
                array[array.Length - 1] = temp;
            }

            return array;
        }

        public static int[] LeftCircularRotationByNewArray(int[] array)
        {
            if (array.Length == 0)
                return array;

            var result = new int[array.Length];

            //1 2 3 4 5 -> 2 3 4 5 1
            for (int i = 0; i < array.Length - 1; i++)
                result[i] = array[i + 1];

            result[result.Length - 1] = array[0];

            return result;
        }

        public static int[] LeftCircularRotation(int[] array)
        {
            if (array.Length == 0)
                return array;

            int temp = 0;

            for(int i=array.Length-1; i>0; i--)
            {
                temp = array[i];
                array[i] = array[0];
                array[0] = temp;
            }

            return array;
        }
    }
}
