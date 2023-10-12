using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var output = new List<IList<int>>();
            Array.Sort(nums);

            int left = 0, middle = 1, right = 2;
            while (left < nums.Length - 2) 
            {
                while (middle < nums.Length - 1) 
                {
                    while (right < nums.Length)
                    {
                        var sum = nums[left] + nums[middle] + nums[right];
                        if (sum == 0)
                        {
                            output.Add(new List<int>() { nums[left], nums[middle], nums[right] });
                        }
                        right++;
                    }
                    middle++;
                    right = middle + 1;
                }
                left++;
                middle = left + 1;
                right = middle + 1;
            }

            return output;
        }
    }
}
