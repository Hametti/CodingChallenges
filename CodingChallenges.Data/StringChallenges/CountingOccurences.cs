using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.Data.StringChallenges
{
    public class CountingOccurences
    {
        public static Dictionary<char, int> OccurenceCount(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
                if (str[i] != ' ')
                {
                    if (characterCount.ContainsKey(str[i]))
                        characterCount[str[i]]++;
                    else
                        characterCount.Add(str[i], 1);
                }

            return characterCount;
        }
    }
}
