/*
 * @lc app=leetcode id=342 lang=csharp
 *
 * [342] Power of Four
 *
 * https://leetcode.com/problems/power-of-four/description/
 *
 * algorithms
 * Easy (41.35%)
 * Likes:    682
 * Dislikes: 235
 * Total Accepted:    202.6K
 * Total Submissions: 489K
 * Testcase Example:  '16'
 *
 * Given an integer (signed 32 bits), write a function to check whether it is a
 * power of 4.
 *
 * Example 1:
 *
 *
 * Input: 16
 * Output: true
 *
 *
 *
 * Example 2:
 *
 *
 * Input: 5
 * Output: false
 *
 *
 * Follow up: Could you solve it without loops/recursion?
 */
using System;

namespace _342
{

    // @lc code=start
    public class Solution {
        public bool IsPowerOfFour(int num) {
            // a = 4 ^ b
            // log_4 a = b
            var b = Math.Log(num, 4);
            return b == (int)b;
        }
    }
    // @lc code=end

}
