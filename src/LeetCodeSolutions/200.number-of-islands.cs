using System.Linq;
using System.Collections.Generic;
/*
 * @lc app=leetcode id=200 lang=csharp
 *
 * [200] Number of Islands
 *
 * https://leetcode.com/problems/number-of-islands/description/
 *
 * algorithms
 * Medium (46.06%)
 * Likes:    5182
 * Dislikes: 192
 * Total Accepted:    692.3K
 * Total Submissions: 1.5M
 * Testcase Example:  '[["1","1","1","1","0"],["1","1","0","1","0"],["1","1","0","0","0"],["0","0","0","0","0"]]'
 *
 * Given a 2d grid map of '1's (land) and '0's (water), count the number of
 * islands. An island is surrounded by water and is formed by connecting
 * adjacent lands horizontally or vertically. You may assume all four edges of
 * the grid are all surrounded by water.
 *
 * Example 1:
 *
 *
 * Input:
 * 11110
 * 11010
 * 11000
 * 00000
 *
 * Output: 1
 *
 *
 * Example 2:
 *
 *
 * Input:
 * 11000
 * 11000
 * 00100
 * 00011
 *
 * Output: 3
 *
 */

namespace _200
{
    // @lc code=start
    public class Solution
    {
        public int NumIslands(char[][] grid)
        {
            var length = grid.Length;
            var cnt = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        cnt++;
                        // looks like DFS is faster for this traversal
                        DFSUtil(grid, i, j);
                        // BFSUtil(grid, i, j);
                    }
                }
            }
            return cnt;
        }

        void BFSUtil(char[][] grid, int k, int n)
        {
            var queue = new Queue<(int i, int j)>();
            queue.Enqueue((k, n));
            var visited = new HashSet<(int i, int j)> { (k, n) };
            while (queue.Count > 0)
            {
                var (x, y) = queue.Dequeue();
                grid[x][y] = '0';
                var query = Directions(x, y).Where(pos =>
                    TryGetDirection(grid, pos.i, pos.j, out var cell)
                        && !visited.Contains(cell));
                foreach (var item in query)
                {
                    visited.Add(item);
                    queue.Enqueue(item);
                }
            }
        }

        void DFSUtil(char[][] grid, int i, int j)
        {
            if (!TryGetDirection(grid, i, j, out var _))
                return;
            grid[i][j] = '0';
            foreach (var (k, v) in Directions(i, j))
            {
                DFSUtil(grid, k, v);
            }
        }
        bool TryGetDirection(char[][] grid, int k, int n, out (int i, int j) found)
        {
            if (k < 0 || k >= grid.Length
                || n < 0 || n >= grid[k].Length
                || grid[k][n] == '0')
            {
                found = (int.MinValue, int.MinValue);
                return false;
            }
            found = (k, n);
            return true;
        }
        IEnumerable<(int i, int j)> Directions(int i, int j)
        {
            yield return (i, j - 1);
            yield return (i - 1, j);
            yield return (i, j + 1);
            yield return (i + 1, j);
        }
    }
    // @lc code=end
}
