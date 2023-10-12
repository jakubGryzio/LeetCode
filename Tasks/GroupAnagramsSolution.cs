using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class GroupAnagramsSolution
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var anagrams = new Dictionary<string, IList<string>>();
            foreach(var str in strs)
            {
                var charValue = new string(GetCharValue(str));
                if (!anagrams.ContainsKey(charValue))
                {
                    anagrams[charValue] = new List<string>();
                }
                anagrams[charValue].Add(str); 
            }

            return anagrams.Values.ToList();
        }

        public static char[] GetCharValue(string str)
        {
            char[] charValue = new char[26];
            foreach(var c in str)
            {
                charValue[c - 'a']++;
            }

            return charValue;
        }
    }
}
