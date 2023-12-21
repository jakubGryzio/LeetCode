using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Collections
{
    public class MyArray
    {
        public static int PivotIndex(int[] nums)
        {
            int sumLeft = 0;
            int sumRight = nums.Sum();

            for (int i = 0; i < nums.Length; i++)
            {
                sumRight -= nums[i];

                if (sumLeft == sumRight)
                {
                    return i;
                }

                sumLeft += nums[i];
            }

            return -1;
        }

        public static int DominantIndex(int[] nums)
        {
            int largestIndex = 0;
            int secondLargest = 0;

            for (int i = 1; i < nums.Length;i++)
            {
                if (nums[i] > nums[largestIndex])
                {
                    secondLargest = nums[largestIndex];
                    largestIndex = i;
                }
                else if (nums[i] > secondLargest)
                {
                    secondLargest = nums[i];
                }
            }

            return nums[largestIndex] >= 2 * secondLargest ? largestIndex : -1;
        }

        public static int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }
            //if all digits are 9 add 1 to start of sequence
            return digits.Prepend(1).ToArray();
        }

        public static int[] FindDiagonalOrder(int[][] mat)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            var output = new List<int>();
            for (int i = 1; i <= n + m - 1; i++)
            {
                var diagonal = new List<int>();
                for (int j = Math.Max(0, i - n); j < Math.Min(m, i); j++)
                {
                    diagonal.Add(mat[j][i - j - 1]);
                }

                if (i % 2 == 0)
                {
                    output.AddRange(diagonal);
                }
                else
                {
                    output.AddRange(diagonal.Reverse<int>());
                }
            }

            return output.ToArray();
        }
    }
}
