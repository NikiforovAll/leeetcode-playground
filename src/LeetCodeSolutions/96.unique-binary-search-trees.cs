/*
 * @lc app=leetcode id=96 lang=csharp
 *
 * [96] Unique Binary Search Trees
 *
 * https://leetcode.com/problems/unique-binary-search-trees/description/
 *
 * algorithms
 * Medium (50.78%)
 * Likes:    3120
 * Dislikes: 117
 * Total Accepted:    279.7K
 * Total Submissions: 545.5K
 * Testcase Example:  '3'
 *
 * Given n, how many structurally unique BST's (binary search trees) that store
 * values 1 ... n?
 *
 * Example:
 *
 *
 * Input: 3
 * Output: 5
 * Explanation:
 * Given n = 3, there are a total of 5 unique BST's:
 *
 * ⁠  1         3     3      2      1
 * ⁠   \       /     /      / \      \
 * ⁠    3     2     1      1   3      2
 * ⁠   /     /       \                 \
 * ⁠  2     1         2                 3
 *
 *
 */
namespace _96
{

    // @lc code=start
    public class Solution
    {
        public int NumTrees(int n)
        {
            var dp = new int[n + 1];
            (dp[0], dp[1]) = (1, 1);
            for (var i = 2; i <= n; i++)
                for (var j = 0; j < i; j++)
                    dp[i] += dp[j] * dp[i - j - 1]; // catalan number
            return dp[n];
        }
    }
    //https://www.youtube.com/watch?v=YDf982Lb84o&list=PLrmLmBdmIlpsHaNTPP_jHHDx_os9ItYX
    // @lc code=end
}

