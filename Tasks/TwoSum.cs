using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class TwoSum
    {
        public static int[] TwoSumSolution(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                var found = Array.FindIndex(nums.Skip(i + 1).ToArray(), elem => elem == target - nums[i]);
                if (found != -1)
                {
                    return new int[2] { i, found + i + 1 };
                }
            }

            return new int[] { };
        }
    }
}
