using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercises
{
    internal class IsPalindromeSolution
    {
        public bool IsPalindrome(string s)
        {
            var palindrome = Regex.Replace(s, "[^A-Za-z0-9]", "").ToLower();
            if (string.IsNullOrEmpty(palindrome))
                return true;
            int count = palindrome.Length / 2;
            for (int i = 0; i < count; i++)
            {
                if (palindrome[i] != palindrome[palindrome.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }
}
