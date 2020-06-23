/*
 * @lc app=leetcode id=222 lang=csharp
 *
 * [222] Count Complete Tree Nodes
 *
 * https://leetcode.com/problems/count-complete-tree-nodes/description/
 *
 * algorithms
 * Medium (42.71%)
 * Likes:    1925
 * Dislikes: 194
 * Total Accepted:    211.8K
 * Total Submissions: 482K
 * Testcase Example:  '[1,2,3,4,5,6]'
 *
 * Given a complete binary tree, count the number of nodes.
 *
 * Note:
 *
 * Definition of a complete binary tree from Wikipedia:
 * In a complete binary tree every level, except possibly the last, is
 * completely filled, and all nodes in the last level are as far left as
 * possible. It can have between 1 and 2^h nodes inclusive at the last level
 * h.
 *
 * Example:
 *
 *
 * Input:
 * ⁠   1
 * ⁠  / \
 * ⁠ 2   3
 * ⁠/ \  /
 * 4  5 6
 *
 * Output: 6
 *
 */
namespace _222
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
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
     *         this.val = val;
     *         this.left = left;
     *         this.right = right;
     *     }
     * }
     */
    public class Solution
    {
        public int CountNodes(TreeNode root) => root switch
        {
            null => 0,
            _ => PickPath(root)
        };

        private int PickPath(TreeNode node)
        {
            int l = LeftHeight(node.left), r = LeftHeight(node.right);
            return l == r
                ? (1 << l) + CountNodes(node.right)
                : (1 << r) + CountNodes(node.left);
        }
        public int LeftHeight(TreeNode node)
        {
            var h = 0;
            while (node != null)
            {
                h++;
                node = node.left;
            }
            return h;
        }
    }
    // @lc code=end
}
