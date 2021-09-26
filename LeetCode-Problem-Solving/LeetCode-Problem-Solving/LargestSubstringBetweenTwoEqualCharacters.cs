using System;
using System.Collections.Generic;

namespace LeetCode_Problem_solving
{
    public class LargestSubstringBetweenTwoEqualCharacters
    {
        public static int MaxLengthBetweenEqualCharacters(string s)
        {
            var result = -1;
            var dictionary = new Dictionary<char, int>();

            for (var i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (dictionary.ContainsKey(c))
                    result = Math.Max(result, i - dictionary[c]);
                else dictionary[c] = i;
            }
            return result == -1 ? -1 : result - 1;
        }
    }
}
