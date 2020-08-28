/*
 * @lc app=leetcode id=448 lang=csharp
 *
 * [448] Find All Numbers Disappeared in an Array
 *
 * https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/
 *
 * algorithms
 * Easy (55.64%)
 * Likes:    3102
 * Dislikes: 255
 * Total Accepted:    280.2K
 * Total Submissions: 500.7K
 * Testcase Example:  '[4,3,2,7,8,2,3,1]'
 *
 * Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array), some
 * elements appear twice and others appear once.
 *
 * Find all the elements of [1, n] inclusive that do not appear in this array.
 *
 * Could you do it without extra space and in O(n) runtime? You may assume the
 * returned list does not count as extra space.
 *
 * Example:
 *
 * Input:
 * [4,3,2,7,8,2,3,1]
 *
 * Output:
 * [5,6]
 *
 *
 */

using System.Collections.Generic;
using System.Linq;

namespace _448
{
    // @lc code=start
    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {

            var length = nums.Length;
            var ind = 0;
            while (ind < length)
            {
                ref var toSwap = ref nums[nums[ind] - 1];
                (nums[ind], toSwap) = (toSwap, nums[ind]);
                if (nums[ind] == ind || nums[ind] == toSwap)
                    ind++;
            }
            return nums
                .Select((c, i) => (c, i: i + 1))
                .Where(t => t.i != t.c)
                .Select(t => t.i)
                .ToList();
        }
        // public IList<int> FindDisappearedNumbers(int[] nums)
        // {
        //     var counters = new int[nums.Length];
        //     for (int i = 0; i < nums.Length; i++)
        //     {
        //         counters[nums[i] - 1]++;
        //     }
        //     return counters
        //         .Select((c, i) => (c, i))
        //         .Where((t, _) => t.c == 0)
        //         .Select(t => t.i + 1)
        //         .ToList();
        // }
    }
    // @lc code=end
}
