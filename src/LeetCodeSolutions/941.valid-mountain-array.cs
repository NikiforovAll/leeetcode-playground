/*
 * @lc app=leetcode id=941 lang=csharp
 *
 * [941] Valid Mountain Array
 *
 * https://leetcode.com/problems/valid-mountain-array/description/
 *
 * algorithms
 * Easy (34.43%)
 * Likes:    369
 * Dislikes: 66
 * Total Accepted:    56.2K
 * Total Submissions: 164.7K
 * Testcase Example:  '[2,1]'
 *
 * Given an array A of integers, return true if and only if it is a valid
 * mountain array.
 *
 * Recall that A is a mountain array if and only if:
 *
 *
 * A.length >= 3
 * There exists some i with 0 < i < A.length - 1 such that:
 *
 * A[0] < A[1] < ... A[i-1] < A[i]
 * A[i] > A[i+1] > ... > A[A.length - 1]
 *
 *
 *
 *
 *
 *
 *
 *
 *
 * Example 1:
 *
 *
 * Input: [2,1]
 * Output: false
 *
 *
 *
 * Example 2:
 *
 *
 * Input: [3,5,5]
 * Output: false
 *
 *
 *
 * Example 3:
 *
 *
 * Input: [0,3,2,1]
 * Output: true
 *
 *
 *
 *
 *
 * Note:
 *
 *
 * 0 <= A.length <= 10000
 * 0 <= A[i] <= 10000 
 *
 *
 *
 *
 *
 *
 *
 *
 *
 */

namespace _941
{
    // @lc code=start
    public class Solution
    {
        public bool ValidMountainArray(int[] A)
        {
            if (A.Length < 3)
            {
                return false;
            }
            var apex = false;
            if (A[0] >= A[1])
                return false;
            for (int i = 1; i < A.Length; i++)
            {
                var a = apex ? A[i - 1] : A[i];
                var b = apex ? A[i] : A[i - 1];
                if ((apex && a < b) || a == b)
                    return false;
                else if (!apex && a < b)
                    apex = true;
            }
            return apex;
        }
    }
    // @lc code=end
}
