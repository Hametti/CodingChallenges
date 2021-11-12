using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.Data.StringChallenges
{
    public class Substrings
    {
        public static string AllPossibleSubstrings(string str)
        {
            List<string> substringList = new List<string>();

            for(int i=0; i<str.Length; i++)
            {
                string subString = "";
                for(int j=i; j<str.Length; j++)
                {
                    subString += str[j];
                    substringList.Add(subString);
                }
            }

            string result = "";
            foreach (string word in substringList)
                result += word + " ";

            return result;
        }
    }
}
