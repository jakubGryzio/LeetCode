using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MaximumWealth
    {
        public static int Execute(int[][] accounts)
        {
            int winner = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int sum = accounts[i].Sum();

                if (winner < sum)
                {
                    winner = sum;
                }
            }

            return winner;
        }
    }
}
