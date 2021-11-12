using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.Data.StringChallenges
{
    public class RemoveDuplicates
    {
        public static string RemoveDuplicatesFromString(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
                if (result.Contains(str[i]))
                    continue;
                else
                    result += str[i];

            return result;
        }
    }
}
