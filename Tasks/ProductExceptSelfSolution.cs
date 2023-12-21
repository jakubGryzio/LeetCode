using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ProductExceptSelfSolution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            int prefix = 1, postfix = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = prefix;
                prefix *= nums[i];
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= postfix;
                postfix *= nums[i];
            }

            return result;
        }

        public int[] ProductExceptSelfII(int[] nums)
        {
            var maxProduct = 1;
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    maxProduct *= nums[i];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    result[i] = 0;
                }
                else
                {
                    result[i] = maxProduct / nums[i];
                }
            }

            return result;
        }
    }
}
