using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.Data.StringChallenges
{
    public class Palindrome
    {
        public static bool PalindromeCheck(string content)
        {
            content = content.ToLower();
            bool flag = true;

            for(int i=0, j=content.Length-1; i<content.Length/2; i++, j--)
                if (content[i] != content[j])
                    flag = false;

            return flag;
        }
    }
}
