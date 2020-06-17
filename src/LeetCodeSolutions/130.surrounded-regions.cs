using System.Collections.Generic;
/*
 * @lc app=leetcode id=130 lang=csharp
 *
 * [130] Surrounded Regions
 *
 * https://leetcode.com/problems/surrounded-regions/description/
 *
 * algorithms
 * Medium (26.26%)
 * Likes:    1493
 * Dislikes: 621
 * Total Accepted:    209.9K
 * Total Submissions: 789.8K
 * Testcase Example:  '[["X","X","X","X"],["X","O","O","X"],["X","X","O","X"],["X","O","X","X"]]'
 *
 * Given a 2D board containing 'X' and 'O' (the letter O), capture all regions
 * surrounded by 'X'.
 *
 * A region is captured by flipping all 'O's into 'X's in that surrounded
 * region.
 *
 * Example:
 *
 *
 * X X X X
 * X O O X
 * X X O X
 * X O X X
 *
 *
 * After running your function, the board should be:
 *
 *
 * X X X X
 * X X X X
 * X X X X
 * X O X X
 *
 *
 * Explanation:
 *
 * Surrounded regions shouldn’t be on the border, which means that any 'O' on
 * the border of the board are not flipped to 'X'. Any 'O' that is not on the
 * border and it is not connected to an 'O' on the border will be flipped to
 * 'X'. Two cells are connected if they are adjacent cells connected
 * horizontally or vertically.
 *
 */
namespace _130
{
    // @lc code=start
    public class Solution
    {
        public void Solve(char[][] board)
        {
            for (int i = 1; i < board.Length - 1; i++)
            {
                for (int j = 1; j < board[0].Length - 1; j++)
                {
                    var @checked = new HashSet<(int i, int j)>();
                    if (TryCheckPosition(board, i, j, @checked))
                    {
                        foreach (var item in @checked)
                        {
                            board[item.i][item.j] = 'X';
                        }
                    }
                }
            }
        }

        public bool TryCheckPosition(char[][] board, int i, int j, HashSet<(int i, int j)> @checked)
        {
            var isFound = TryGetCell(board, i, j, out var curr);
            if (!isFound)
            {
                return false;
            }
            if (curr == 'X')
            {
                return true;
            }
            // board[i][j] = 'X';
            @checked.Add((i, j));
            var moves = new (int i, int j)[]{
                (i - 1, j),
                (i, j - 1),
                (i + 1, j),
                (i, j + 1),
            };
            foreach (var move in moves)
            {
                if (!@checked.Contains(move) && !TryCheckPosition(board, move.i, move.j, @checked))
                {
                    return false;
                }
            }
            return true;

            static bool TryGetCell(char[][] board, int i, int j, out char res)
            {
                if (i >= 0 && i < board.Length && j >= 0 && j < board[0].Length)
                {
                    res = board[i][j];
                    return true;
                }
                res = '!';
                return false;
            }

        }
    }
    // @lc code=end
}
