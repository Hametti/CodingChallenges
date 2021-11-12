using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenges.Data.StringChallenges
{
    public class ReversingString
    {
        public static string ReverseString(string content)
        {
            string result = "";
            for (int i = content.Length-1; i >= 0; i--)
                result += content[i];

            return result;
        }

        public static string ReverseStringByRecursion(string content)
        {
            if (content.Length == 1)
                return content;

            return content[content.Length - 1] + ReverseStringByRecursion(content.Substring(0, content.Length - 1));
        }
        public static string ReverseStringByCharArray(string content)
        {
            char[] charArray = new char[content.Length];
            int j = 0;

            for (int i = content.Length - 1; i >= 0; i--, j++)
                charArray[j] = content[i];

            string result = new string(charArray);
            return result;
        }

        public static string ReverseStringBuiltInMethod(string content)
        {
            char[] charArray = content.ToCharArray();
            charArray = charArray.Reverse().ToArray();
            return new string(charArray);
        }
    }
}
