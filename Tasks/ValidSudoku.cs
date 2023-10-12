using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            int[,] column = new int[9,9];
            int[,,] grid = new int[3, 3, 9];
            for ( int i = 0; i < board.Length; i++)
            {
                if (!Validate(board[i], i, ref column, ref grid)) 
                {
                    return false;
                }
            }

            return true;
        }

        private static bool Validate(char[] row, int rowNumber, ref int[,] column, ref int[,,] grid)
        {
            int[] result = new int[9];
            for (int i = 0; i < row.Length; i++)
            {
                if (row[i] != '.') 
                {
                    result[row[i] - '1']++;

                    column[i, row[i] - '1']++;

                    grid[i / 3, rowNumber / 3, row[i] - '1']++;

                    if (grid[i / 3, rowNumber / 3, row[i] - '1'] > 1)
                        return false;

                    if (column[i, row[i] - '1'] > 1)
                        return false;

                    if (result[row[i] - '1'] > 1)
                        return false;
                }
            }

            return true;
        }
    }
}
