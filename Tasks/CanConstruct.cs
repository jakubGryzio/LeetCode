using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class CanConstruct
    {
        public static bool Execute(string ransomNote, string magazine)
        {
            var hashMap = new Dictionary<char, int>();

            foreach (var letter in magazine)
            {
                if (!hashMap.TryGetValue(letter, out _))
                {
                    hashMap[letter] = 0;
                }

                hashMap[letter]++;
            }

            foreach (var letter in ransomNote)
            {
                if (hashMap.TryGetValue(letter, out int value))
                {
                    if (value == 0)
                    {
                        return false;
                    }

                    hashMap[letter]--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
