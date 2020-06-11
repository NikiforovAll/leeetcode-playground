using System;
/*
 * @lc app=leetcode id=75 lang=csharp
 *
 * [75] Sort Colors
 *
 * https://leetcode.com/problems/sort-colors/description/
 *
 * algorithms
 * Medium (45.53%)
 * Likes:    3150
 * Dislikes: 214
 * Total Accepted:    480.1K
 * Total Submissions: 1M
 * Testcase Example:  '[2,0,2,1,1,0]'
 *
 * Given an array with n objects colored red, white or blue, sort them in-place
 * so that objects of the same color are adjacent, with the colors in the order
 * red, white and blue.
 *
 * Here, we will use the integers 0, 1, and 2 to represent the color red,
 * white, and blue respectively.
 *
 * Note: You are not suppose to use the library's sort function for this
 * problem.
 *
 * Example:
 *
 *
 * Input: [2,0,2,1,1,0]
 * Output: [0,0,1,1,2,2]
 *
 * Follow up:
 *
 *
 * A rather straight forward solution is a two-pass algorithm using counting
 * sort.
 * First, iterate the array counting number of 0's, 1's, and 2's, then
 * overwrite array with total number of 0's, then 1's and followed by 2's.
 * Could you come up with a one-pass algorithm using only constant space?
 *
 *
 */
namespace _75
{
    // @lc code=start
    public class Solution
    {
        // public void SortColors(int[] nums)
        // {
        //     int start = 0, end = nums.Length - 1;
        //     for (int i = 0; i <= end; i++)
        //     {
        //         var curr = nums[i];
        //         if (curr == 0)
        //         {
        //             nums[start++] = 0;
        //         }
        //         else if (curr == 2)
        //         {
        //             (nums[end], nums[i]) = (nums[i], nums[end]);
        //             end--;
        //             i--;
        //         }
        //     }
        //     while(start <= end){
        //         nums[start++] = 1;
        //     }
        // }
        // TODO: not finished
        // public void SortColors(int[] nums)
        // {
        //     int start = 0, end = nums.Length - 1;
        //     for (int i = 0; i <= end; i++)
        //     {
        //         while (nums[i] == 0 && i > start)
        //         {
        //             (nums[i], nums[start]) = (nums[start], nums[i]);
        //             start++;
        //         }
        //         while (nums[i] == 2 && i < end)
        //         {
        //             (nums[i], nums[end]) = (nums[end], nums[i]);
        //             end--;
        //         }
        //     }
        // }
    }
    // @lc code=end
}
