using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class NumberOfSteps
    {
        public static int Execute(int num)
        {
            int counter = 0;

            while (num != 0)
            {
                bool even = num % 2 == 0;

                if (even)
                {
                    num /= 2;
                }

                if (!even)
                {
                    num -= 1;
                }

                counter++;
            }

            return counter;
        }

        public static int ExecuteBinary(int num)
        {
            int counter = 0;

            while (num != 0)
            {
                if ((num & 1) == 0)
                {
                    num >>= 1;
                }
                else
                {
                    num--;
                }
                counter++;
            }

            return counter;
        }
    }
}
