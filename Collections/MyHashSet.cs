using Exercises.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Collections
{
    public class MyHashSet : IMyHashSet
    {
        private readonly int[] hashSet;

        public MyHashSet()
        {
            this.hashSet = new int[(int)Math.Pow(10, 6) + 1];
        }
        public void Add(int key)
        {
            this.hashSet[key] = 1;
        }

        public bool Contains(int key)
        {
            return this.hashSet[key] == 1;
        }

        public void Remove(int key)
        {
            this.hashSet[key] = 0;
        }

        public bool ContainsDuplicate(int[] nums)
        {
            var distinctNums = new HashSet<int>();

            foreach (int num in nums)
            {
                if (distinctNums.Contains(num))
                    return true;
                distinctNums.Add(num);
            }

            return false;
        }

        public static int SingleNumber(int[] nums)
        {
            var hashSet = new HashSet<int>();

            foreach (int num in nums)
            {
                if (hashSet.Contains(num))
                {
                    hashSet.Remove(num);
                }
                else
                {
                    hashSet.Add(num);
                }
            }

            return hashSet.First();

            /*Array.Sort(nums);
            for (int i = 1; i < nums.Length; i += 2)
            {
                if (nums[i] != nums[i - 1])
                {
                    return nums[i - 1];
                }
            }
            return nums[nums.Length - 1];*/
        }

        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            var nums1Frequency = new Dictionary<int, int>();
            var output = new List<int>();

            foreach (var num in nums1)
            {
                if (!nums1Frequency.TryGetValue(num, out _))
                {
                    nums1Frequency[num] = 0;
                }
                nums1Frequency[num]++;
            }

            foreach (var num in new HashSet<int>(nums2))
            {
                if (nums1Frequency.TryGetValue(num, out _))
                {
                    output.Add(num);
                }
            }

            return output.ToArray();
        }

        public static bool IsHappy(int n)
        {
            var sums = new HashSet<int>();  
            var sum = 1;
            while (!sums.Contains(sum))
            {
                sums.Add(sum);
                sum = 0;

                while (n > 0)
                {
                    sum += (int)Math.Pow(n % 10, 2);
                    n /= 10;
                }

                n = sum;
            }

            return sum == 1;
        }
    }
}
