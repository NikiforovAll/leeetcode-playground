/*
 * @lc app=leetcode id=69 lang=csharp
 *
 * [69] Sqrt(x)
 *
 * https://leetcode.com/problems/sqrtx/description/
 *
 * algorithms
 * Easy (33.46%)
 * Likes:    1252
 * Dislikes: 1845
 * Total Accepted:    535.9K
 * Total Submissions: 1.6M
 * Testcase Example:  '4'
 *
 * Implement int sqrt(int x).
 *
 * Compute and return the square root of x, where x is guaranteed to be a
 * non-negative integer.
 *
 * Since the return type is an integer, the decimal digits are truncated and
 * only the integer part of the result is returned.
 *
 * Example 1:
 *
 *
 * Input: 4
 * Output: 2
 *
 *
 * Example 2:
 *
 *
 * Input: 8
 * Output: 2
 * Explanation: The square root of 8 is 2.82842..., and since
 * the decimal part is truncated, 2 is returned.
 *
 *
 */

namespace _69
{
    // @lc code=start
    public class Solution
    {
        public int MySqrt(int x)
        {
            if (x == 0)
                return 0;

            int left = 1;
            int right = x;
            while (true)
            {
                int mid = left + (right - left) / 2;
                if (mid > x/mid)
                {
                    right = mid - 1;
                }
                else
                {
                    if (mid + 1 > x / (mid + 1))
                        return mid;
                    left = mid + 1;
                }
            }
        }
    }
    // @lc code=end
}
