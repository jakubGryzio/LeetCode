using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class RunningSum
    {
        public static int[] Execute(int[] nums)
        {
            int temp = 0;
            var output = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                output[i] = temp + nums[i];
                temp += nums[i];
            }

            return output;
        }
    }
}
