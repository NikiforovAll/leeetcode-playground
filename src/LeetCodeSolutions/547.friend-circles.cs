using System.Linq;
using System.Net.NetworkInformation;
using System.Collections.Generic;
/*
 * @lc app=leetcode id=547 lang=csharp
 *
 * [547] Friend Circles
 *
 * https://leetcode.com/problems/friend-circles/description/
 *
 * algorithms
 * Medium (57.65%)
 * Likes:    1701
 * Dislikes: 127
 * Total Accepted:    153K
 * Total Submissions: 265.4K
 * Testcase Example:  '[[1,1,0],[1,1,0],[0,0,1]]'
 *
 *
 * There are N students in a class. Some of them are friends, while some are
 * not. Their friendship is transitive in nature. For example, if A is a direct
 * friend of B, and B is a direct friend of C, then A is an indirect friend of
 * C. And we defined a friend circle is a group of students who are direct or
 * indirect friends.
 *
 *
 *
 * Given a N*N matrix M representing the friend relationship between students
 * in the class. If M[i][j] = 1, then the ith and jth students are direct
 * friends with each other, otherwise not. And you have to output the total
 * number of friend circles among all the students.
 *
 *
 * Example 1:
 *
 * Input:
 * [[1,1,0],
 * ⁠[1,1,0],
 * ⁠[0,0,1]]
 * Output: 2
 * Explanation:The 0th and 1st students are direct friends, so they are in a
 * friend circle. The 2nd student himself is in a friend circle. So return
 * 2.
 *
 *
 *
 * Example 2:
 *
 * Input:
 * [[1,1,0],
 * ⁠[1,1,1],
 * ⁠[0,1,1]]
 * Output: 1
 * Explanation:The 0th and 1st students are direct friends, the 1st and 2nd
 * students are direct friends, so the 0th and 2nd students are indirect
 * friends. All of them are in the same friend circle, so return 1.
 *
 *
 *
 *
 * Note:
 *
 * N is in range [1,200].
 * M[i][i] = 1 for all students.
 * If M[i][j] = 1, then M[j][i] = 1.
 *
 *
 */
namespace _547
{
    // @lc code=start
    public class Solution
    {
        public int FindCircleNum(int[][] M)
        {
            var visited = new HashSet<int>();
            var cnt = 0;
            for (int i = 0; i < M.Length; i++)
            {
                if (!visited.Contains(i))
                {
                    DFSUtil(M, i, visited);
                    cnt++;
                }
            }
            return cnt;
        }

        private void DFSUtil(int[][] M, int k, HashSet<int> visited)
        {
            var length = M.Length;
            var stack = new Stack<int>(length);
            stack.Push(k);
            while (stack.Count != 0)
            {
                var current = stack.Pop();
                if (!visited.Add(current))
                {
                    continue;
                }
                for (int i = 0; i < M[k].Length; i++)
                {
                    if (!visited.Contains(i) && M[current][i] == 1)
                    {
                        stack.Push(i);
                    }
                }
            }
        }
    }
    // @lc code=end
}
