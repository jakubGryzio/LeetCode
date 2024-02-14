using Exercises.Contracts;
using Exercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Collections
{
    public class MyHashMap : IMyHashMap
    {
        private readonly int[] hashMap;

        public MyHashMap()
        {
            this.hashMap = new int[(int)Math.Pow(10, 6) + 1];
            for (int i = 0; i < this.hashMap.Length; i++)
            {
                this.hashMap[i] = -1;
            }
        }
        public int Get(int key)
        {
            return this.hashMap[key];
        }

        public void Put(int key, int value)
        {
            this.hashMap[key] = value;
        }

        public void Remove(int key)
        {
            this.hashMap[key] = -1;
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var hashMap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var found = target - nums[i];
                if (hashMap.TryGetValue(found, out int index))
                {
                    return new int[2] { index, i };
                }
                hashMap[nums[i]] = i;
            }

            return new int[] { };
        }

        public static bool IsIsomorphic(string s, string t)
        {
            if (new HashSet<char>(s).Count != new HashSet<char>(t).Count)
            {
                return false;
            }

            var hashMap = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (hashMap.TryGetValue(s[i], out char mappedChar))
                {
                    if (mappedChar != t[i])
                    {
                        return false;
                    }
                }

                hashMap[s[i]] = t[i];
            }

            return true;
        }

        public static string[] FindRestaurant(string[] list1, string[] list2)
        {
            int winner = list1.Length + list2.Length - 2;
            var hashMapList1 = new Dictionary<string, int>();
            var hashMapList2 = new Dictionary<string, int>();

            for (int i = 0; i < list1.Length; i++)
            {
                if (!hashMapList1.TryGetValue(list1[i], out _))
                {
                    hashMapList1[list1[i]] = 0;
                }
                hashMapList1[list1[i]] += i;
            }

            for (int i = 0; i < list2.Length; i++)
            {
                if (!hashMapList2.TryGetValue(list2[i], out _))
                {
                    hashMapList2[list2[i]] = 0;
                }
                hashMapList2[list2[i]] += i;
            }

            foreach (var pair in hashMapList1)
            {
                if (hashMapList2.TryGetValue(pair.Key, out int counter))
                {
                    var sumIndexes = pair.Value + counter;
                    winner = Math.Min(winner, sumIndexes);
                    hashMapList1[pair.Key] = sumIndexes;
                } 
                else
                {
                    hashMapList1[pair.Key] = -1;
                }
            }

            return hashMapList1.Where(keyValuePair => keyValuePair.Value == winner)
                          .Select(keyValuePair => keyValuePair.Key).ToArray();
        }

        public static int FirstUniqChar(string s)
        {
            /*var hashMap = new Dictionary<char, int>();
            foreach (var ch in s)
            {
                if (!hashMap.TryGetValue(ch, out _))
                {
                    hashMap[ch] = 0;
                }

                hashMap[ch]++;
            }

            foreach (var pair in hashMap)
            {
                if (pair.Value == 1)
                {
                    return s.IndexOf(pair.Key);
                }
            }

            return -1;*/
            var ascii = new char[26];
            foreach (char c in s )
            {
                ascii[c - 97]++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (ascii[s[i] - 97] == 1)
                {
                    return i;
                }
            }

            return -1;
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

            foreach (var num in nums2)
            {
                if (nums1Frequency.TryGetValue(num, out int freq))
                {
                    if (freq > 0)
                    {
                        output.Add(num);
                        nums1Frequency[num]--;
                    }
                }
            }

            return output.ToArray();
        }

        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var hashMap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashMap.TryGetValue(nums[i], out int value))
                {
                    if (Math.Abs(value - i) <= k)
                    {
                        return true;
                    }
                }

                hashMap[nums[i]] = i;
            }

            return false;
        }

        public static IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            TreeNode.GetNode(root);
            return null;
        }

        public static int NumJewelsInStones(string jewels, string stones)
        {
            int counter = 0;
            char[] ascii = new char[58];
            foreach (char c in jewels)
            {
                ascii[c - 65]++;
            }

            foreach (char c in stones)
            {
                counter += ascii[c - 65];
            }

            return counter;
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int winner = 0;
            var current = 0;
            var hashSet = new HashSet<char>();
            foreach (char c in s)
            {
                current++;
                if (hashSet.Contains(c))
                {
                    hashSet.Remove(c);
                    current--;
                }
                else
                {
                    winner = Math.Max(winner, current);
                }
                hashSet.Add(c);
            }

            return winner;
        }
    }
}
