using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class TopKFrequentSolution
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            if (nums.Length == k) return nums;

            var frequency = new Dictionary<int, int>();
            foreach (int num in nums) 
            {
                if (!frequency.ContainsKey(num))
                {
                    frequency[num] = 0;
                }
                frequency[num]++;
            }

            frequency = frequency.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            return frequency.Keys.Take(k).ToArray();
        }
    }
}
