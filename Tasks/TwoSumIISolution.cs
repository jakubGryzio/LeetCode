using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class TwoSumIISolution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var left = 0;
            var right = numbers.Length - 1;

            while(left < right)
            {
                int sum = numbers[left] + numbers[right];
                if (sum > target)
                {
                    right--;
                }
                else if (sum < target)
                {
                    left++;
                } 
                else
                {
                    return new int[] { left + 1, right + 1};
                }
            }
            return new int[] { };
        }
    }
}
