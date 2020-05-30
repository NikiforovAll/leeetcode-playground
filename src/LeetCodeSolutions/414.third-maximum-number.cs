/*
 * @lc app=leetcode id=414 lang=csharp
 *
 * [414] Third Maximum Number
 *
 * https://leetcode.com/problems/third-maximum-number/description/
 *
 * algorithms
 * Easy (30.33%)
 * Likes:    611
 * Dislikes: 1133
 * Total Accepted:    140.4K
 * Total Submissions: 462.9K
 * Testcase Example:  '[3,2,1]'
 *
 * Given a non-empty array of integers, return the third maximum number in this
 * array. If it does not exist, return the maximum number. The time complexity
 * must be in O(n).
 *
 * Example 1:
 *
 * Input: [3, 2, 1]
 *
 * Output: 1
 *
 * Explanation: The third maximum is 1.
 *
 *
 *
 * Example 2:
 *
 * Input: [1, 2]
 *
 * Output: 2
 *
 * Explanation: The third maximum does not exist, so the maximum (2) is
 * returned instead.
 *
 *
 *
 * Example 3:
 *
 * Input: [2, 2, 3, 1]
 *
 * Output: 1
 *
 * Explanation: Note that the third maximum here means the third maximum
 * distinct number.
 * Both numbers with value 2 are both considered as second maximum.
 *
 *
 */
namespace _414
{
    // @lc code=start
    public class Solution
    {
        public int ThirdMax(int[] nums)
        {
            int? max = null, smax = null, tmax = null;
            for (int i = 0; i < nums.Length; i++)
            {
                int curr = nums[i];
                if (curr == tmax || curr == smax || curr == max)
                    continue;
                if (curr > max || max is null)
                {
                    tmax = smax;
                    smax = max;
                    max = curr;
                }
                else if (curr > smax || smax is null)
                {
                    tmax = smax;
                    smax = curr;
                }
                else if (curr > tmax || tmax is null)
                {
                    tmax = curr;
                }
            }
            return tmax ?? max ?? int.MinValue;
        }
    }
    // @lc code=end
}
