/*
 * @lc app=leetcode id=485 lang=csharp
 *
 * [485] Max Consecutive Ones
 *
 * https://leetcode.com/problems/max-consecutive-ones/description/
 *
 * algorithms
 * Easy (55.48%)
 * Likes:    604
 * Dislikes: 353
 * Total Accepted:    212.6K
 * Total Submissions: 383.9K
 * Testcase Example:  '[1,0,1,1,0,1]'
 *
 * Given a binary array, find the maximum number of consecutive 1s in this
 * array.
 *
 * Example 1:
 *
 * Input: [1,1,0,1,1,1]
 * Output: 3
 * Explanation: The first two digits or the last three digits are consecutive
 * 1s.
 * ⁠   The maximum number of consecutive 1s is 3.
 *
 *
 *
 * Note:
 *
 * The input array will only contain 0 and 1.
 * The length of input array is a positive integer and will not exceed 10,000
 *
 *
 */

// @lc code=start
public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int end = 0, max = 0;
        var length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            if (nums[i] == 1)
            {
                var start = i;
                while (i < length && nums[i] == 1)
                {
                    end = i + 1;
                    i++;
                }
                var l = end - start;
                max = max > l ? max : l;
            }
        }
        return max;
    }

    // public int FindMaxConsecutiveOnes(int[] nums)
    // {
    //     int cnt = 0;
    //     var sum = int.MinValue;
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         if (nums[i] == 0)
    //         {
    //             cnt = 0;
    //         }
    //         else
    //         {
    //             cnt++;
    //         }
    //         sum = sum > cnt ? sum : cnt;
    //     }
    //     return sum;
    // }
}
// @lc code=end

