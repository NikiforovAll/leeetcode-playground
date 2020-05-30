using System.Runtime.Versioning;
using System.Linq;
using System;
/*
 * @lc app=leetcode id=904 lang=csharp
 *
 * [904] Fruit Into Baskets
 *
 * https://leetcode.com/problems/fruit-into-baskets/description/
 *
 * algorithms
 * Medium (42.25%)
 * Likes:    751
 * Dislikes: 1132
 * Total Accepted:    90K
 * Total Submissions: 213K
 * Testcase Example:  '[1,2,1]'
 *
 * In a row of trees, the i-th tree produces fruit with type tree[i].
 *
 * You start at any tree of your choice, then repeatedly perform the following
 * steps:
 *
 *
 * Add one piece of fruit from this tree to your baskets.  If you cannot,
 * stop.
 * Move to the next tree to the right of the current tree.  If there is no tree
 * to the right, stop.
 *
 *
 * Note that you do not have any choice after the initial choice of starting
 * tree: you must perform step 1, then step 2, then back to step 1, then step
 * 2, and so on until you stop.
 *
 * You have two baskets, and each basket can carry any quantity of fruit, but
 * you want each basket to only carry one type of fruit each.
 *
 * What is the total amount of fruit you can collect with this procedure?
 *
 *
 *
 * Example 1:
 *
 *
 * Input: [1,2,1]
 * Output: 3
 * Explanation: We can collect [1,2,1].
 *
 *
 *
 * Example 2:
 *
 *
 * Input: [0,1,2,2]
 * Output: 3
 * Explanation: We can collect [1,2,2].
 * If we started at the first tree, we would only collect [0, 1].
 *
 *
 *
 * Example 3:
 *
 *
 * Input: [1,2,3,2,2]
 * Output: 4
 * Explanation: We can collect [2,3,2,2].
 * If we started at the first tree, we would only collect [1, 2].
 *
 *
 *
 * Example 4:
 *
 *
 * Input: [3,3,3,1,2,1,1,2,3,3,4]
 * Output: 5
 * Explanation: We can collect [1,2,1,1,2].
 * If we started at the first tree or the eighth tree, we would only collect 4
 * fruits.
 *
 *
 *
 *
 *
 *
 *
 * Note:
 *
 *
 * 1 <= tree.length <= 40000
 * 0 <= tree[i] < tree.length
 *
 *
 */

namespace _904
{
    // @lc code=start
    public class Solution
    {
        public int TotalFruit(int[] tree)
        {
            int first = int.MinValue;
            int second = int.MinValue;
            int prev = int.MinValue;
            int prevIndex = int.MinValue;
            int cnt = 0;
            int res = int.MinValue;
            for (var index = 0; index < tree.Length; index++)
            {
                var curr = tree[index];
                var isNew = curr != first && curr != second;
                if (!isNew)
                {
                    cnt++;
                }
                else if (first == int.MinValue)
                {
                    first = curr;
                    cnt++;
                }
                else if (second == int.MinValue)
                {
                    second = curr;
                    cnt++;
                }
                else if (isNew)
                {
                    first = prev;
                    second = curr;
                    res = Math.Max(res, cnt);
                    cnt = index - prevIndex + 1;
                }
                if (curr != prev)
                {
                    prevIndex = index;
                    prev = curr;
                }
            }
            res = Math.Max(res, cnt);
            return res;
        }

        // brute force with condition optimization
        // public int TotalFruit(int[] tree)
        // {
        //     var res = 0;
        //     for (int i = 0; i < tree.Length && tree.Length - i > res; i++)
        //     {
        //         int[] collected = new int[tree.Length];
        //         int typeCnt = 0;
        //         int j;
        //         for (j = i; typeCnt < 3 && j < tree.Length; j++)
        //         {
        //             ref var nOfType = ref collected[tree[j]];
        //             if (nOfType == 0 && typeCnt == 2)
        //                 break;
        //             if (collected[tree[j]] == 0)
        //                 typeCnt++;
        //             nOfType++;
        //         }
        //         res = Math.Max(res, j - i);
        //     }
        //     return res;
        // }
    }
    // @lc code=end
}
