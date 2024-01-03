using System.Linq.Expressions;
using System.Text;

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

        public static IList<int> SpiralOrder(int[][] matrix)
        {
            var output = new List<int>();
            int m = matrix.Length;
            int n = matrix[0].Length;
            int i = 0;

            while (output.Count != m * n)
            {
                //first row
                for (int j = 0 + i; j < n - i; j++)
                {
                    if (output.Count == m * n) return output;
                    output.Add(matrix[i][j]);
                }

                // last column
                for (int j = 1 + i; j < m - i; j++)
                {
                    if (output.Count == m * n) return output;
                    output.Add(matrix[j][n - i - 1]);
                }

                // last row
                for (int j = n - i - 2; j >= i; j--)
                {
                    if (output.Count == m * n) return output;
                    output.Add(matrix[m - i - 1][j]);
                }

                // first column
                for (int j = m - i - 2; j > i; j--)
                {
                    if (output.Count == m * n) return output;
                    output.Add(matrix[j][i]);
                }

                i++;
            }
            return output;
        }

        public static IList<IList<int>> Generate(int numRows)
        {
            var output = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                var newSumArray = new List<int> { 1 };
                for (int j = 1; j < i; j++)
                {
                    newSumArray.Add(output[output.Count - 1][j - 1] + output[output.Count - 1][j]);
                }
                if (i > 0)
                {
                    newSumArray.Add(1);
                }
                output.Add(newSumArray);
            }
            
            return output;
        }

        public static string AddBinary(string a, string b)
        {
            StringBuilder output = new StringBuilder();

            if (a.Length > b.Length)
            {
                b = b.PadLeft(a.Length, '0');
            } 
            else
            {
                a = a.PadLeft(b.Length, '0');
            }

            byte carry = 0;
            for (int i = Math.Max(a.Length, b.Length) - 1; i >= 0; i--)
            {
                byte value = (byte)(Convert.ToByte(a[i]) + Convert.ToByte(b[i]) - 48 * 2 + carry);
                byte bitValue = (byte)(value % 2);
                carry = (byte)(value > 1 ? 1 : 0);
                output.Insert(0, bitValue);
            }

            if (carry != 0)
            {
                output.Insert(0, carry);
            }

            return output.ToString();
        }

        public static int StrStr(string haystack, string needle)
        {
            if (!haystack.Contains(needle[0]) || haystack.Length < needle.Length)
            {
                return -1;
            }

            var firstLetterIdx = -1;
            for (int i = 0; i < haystack.Length; i++)
            {
                firstLetterIdx = haystack.IndexOf(needle[0], firstLetterIdx + 1);
                if (firstLetterIdx == -1 || firstLetterIdx + needle.Length > haystack.Length)
                {
                    return -1;
                }
                var subStr = haystack.Substring(firstLetterIdx, needle.Length);
                if (subStr.Equals(needle))
                {
                    return firstLetterIdx;
                }
            }
            return -1;
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            var minLenStr = strs[0];
            foreach (var elem in strs.Skip(1))
            {
                if (elem.Length < minLenStr.Length)
                {
                    minLenStr = elem;
                }
            }

            for (int i = 0; i < minLenStr.Length; i++)
            {
                var findStr = new string(minLenStr.SkipLast(i).ToArray());
                var findStrInAll = strs.FirstOrDefault(s => !s.StartsWith(findStr));
                if (findStrInAll == null)
                {
                    return findStr;
                }
            }
            return "";
        }

        public static void ReverseString(char[] s)
        {
            /*int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                var temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                i++;
                j--;
            }*/

            for (int i = 0; i < s.Length/2; i++)
            {
                (s[s.Length - 1 - i], s[i]) = (s[i], s[s.Length - 1 - i]);
            }
        }

        public static int ArrayPairSum(int[] nums)
        {
            nums = nums.OrderBy(i => i).ToArray();
            int maxSum = 0;
            for (int i = 0; i < nums.Length; i+=2)
            {
                maxSum += nums[i];
            }

            return maxSum;
        }
    }
}
