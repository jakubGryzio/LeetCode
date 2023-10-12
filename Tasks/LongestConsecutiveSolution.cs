using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LongestConsecutiveSolution
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length < 2) return nums.Length;

            var sortedNums = new HashSet<int>(nums).ToArray();
            int winner = 0, current = 0;
            for (int i = 0; i < sortedNums.Length - 1; i++)
            {
                if (sortedNums[i + 1] - sortedNums[i] == 1)
                {
                    current++;
                    if (current > winner)
                        winner = current;
                }
                else
                {
                    current = 0;
                }
            }

            return winner + 1;
        }
    }
}
