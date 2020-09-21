using System.Linq;
using System;
/*
 * @lc app=leetcode id=1022 lang=csharp
 *
 * [1022] Sum of Root To Leaf Binary Numbers
 *
 * https://leetcode.com/problems/sum-of-root-to-leaf-binary-numbers/description/
 *
 * algorithms
 * Easy (66.08%)
 * Likes:    818
 * Dislikes: 80
 * Total Accepted:    74.5K
 * Total Submissions: 105K
 * Testcase Example:  '[1,0,1,0,1,0,1]'
 *
 * You are given the root of a binary tree where each node has a value 0 or 1.
 * Each root-to-leaf path represents a binary number starting with the most
 * significant bit.  For example, if the path is 0 -> 1 -> 1 -> 0 -> 1, then
 * this could represent 01101 in binary, which is 13.
 *
 * For all leaves in the tree, consider the numbers represented by the path
 * from the root to that leaf.
 *
 * Return the sum of these numbers. The answer is guaranteed to fit in a
 * 32-bits integer.
 *
 *
 * Example 1:
 *
 *
 * Input: root = [1,0,1,0,1,0,1]
 * Output: 22
 * Explanation: (100) + (101) + (110) + (111) = 4 + 5 + 6 + 7 = 22
 *
 *
 * Example 2:
 *
 *
 * Input: root = [0]
 * Output: 0
 *
 *
 * Example 3:
 *
 *
 * Input: root = [1]
 * Output: 1
 *
 *
 * Example 4:
 *
 *
 * Input: root = [1,1]
 * Output: 3
 *
 *
 *
 * Constraints:
 *
 *
 * The number of nodes in the tree is in the range [1, 1000].
 * Node.val is 0 or 1.
 *
 *
 */

namespace _1022
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    // @lc code=start
    public class Solution
    {
        public int SumRootToLeaf(TreeNode root)
        {
            return SumRootToLeafDFS(root).Select(ToDecimalNumber).Sum();
        }

        public string[] SumRootToLeafDFS(TreeNode root)
        {
            if (root == null)
            {
                return Array.Empty<string>();
            }
            var query = SumRootToLeafDFS(root.left).Concat(SumRootToLeafDFS(root.right));
            var nodestr = root.val.ToString();
            return query.Any()
                ? query.Select(n => nodestr + n).ToArray()
                : new string[] { nodestr };
        }

        private int ToDecimalNumber(string number) => Convert.ToInt32(number, 2);
    }
    // @lc code=end
}

