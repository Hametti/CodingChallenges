using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.Data.StringChallenges
{
    public class ReversingWords
    {
        public static string ReverseWordsOrder(string content)
        {
            string result = "";
            if (content.Length < 2)
                return content;

            int startIndex = 0;
            int endIndex = 1;

            List<string> wordList = new List<string>();

            while (endIndex < content.Length)
            {
                if (endIndex == content.Length - 1)
                    wordList.Add(content.Substring(startIndex, content.Length - startIndex));

                else if (content[endIndex] == ' ')
                {
                    if (startIndex < endIndex)
                        wordList.Add(content.Substring(startIndex, endIndex - startIndex));

                    wordList.Add(" ");
                    startIndex = endIndex+1;
                }
                endIndex++;
            }

            wordList.Reverse();

            foreach (string word in wordList)
                result += word;

            return result;
        }

        public static string ReverseEachWord(string content)
        {
            string result = "";
            if (content.Length < 2)
                return content;

            int startIndex = 0;
            int endIndex = 1;

            List<string> wordList = new List<string>();

            while (endIndex < content.Length)
            {
                if (endIndex == content.Length - 1)
                    wordList.Add(content.Substring(startIndex, content.Length - startIndex));

                else if (content[endIndex] == ' ')
                {
                    if (startIndex < endIndex)
                        wordList.Add(content.Substring(startIndex, endIndex - startIndex));

                    wordList.Add(" ");
                    startIndex = endIndex + 1;
                }

                endIndex++;
            }

            foreach (string word in wordList)
            {
                if (word != " ")
                    result += new string(word.Reverse().ToArray());
                else
                    result += word;
            }

            return result;
        }

    }
}
