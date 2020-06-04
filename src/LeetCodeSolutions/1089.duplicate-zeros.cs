using System;
using System.Linq;
/*
 * @lc app=leetcode id=1089 lang=csharp
 *
 * [1089] Duplicate Zeros
 *
 * https://leetcode.com/problems/duplicate-zeros/description/
 *
 * algorithms
 * Easy (55.42%)
 * Likes:    435
 * Dislikes: 181
 * Total Accepted:    50.5K
 * Total Submissions: 91.6K
 * Testcase Example:  '[1,0,2,3,0,4,5,0]'
 *
 * Given a fixed length array arr of integers, duplicate each occurrence of
 * zero, shifting the remaining elements to the right.
 *
 * Note that elements beyond the length of the original array are not written.
 *
 * Do the above modifications to the input array in place, do not return
 * anything from your function.
 *
 *
 *
 * Example 1:
 *
 *
 * Input: [1,0,2,3,0,4,5,0]
 * Output: null
 * Explanation: After calling your function, the input array is modified to:
 * [1,0,0,2,3,0,0,4]
 *
 *
 * Example 2:
 *
 *
 * Input: [1,2,3]
 * Output: null
 * Explanation: After calling your function, the input array is modified to:
 * [1,2,3]
 *
 *
 *
 *
 * Note:
 *
 *
 * 1 <= arr.length <= 10000
 * 0 <= arr[i] <= 9
 *
 */
namespace _1089
{
    // @lc code=start
    public class Solution
    {
        public void DuplicateZeros(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 0)
                {
                    Array.Copy(arr, i + 1, arr, i + 2, arr.Length - i - 2);
                    arr[i++ + 1] = 0;
                }
            }
            // for (int i = 0; i < arr.Length - 1; i++)
            // {
            //     _ = arr[i] == 0 && Shift(i++);
            // }
            // bool Shift(int i)
            // {
            //     // for (int j = arr.Length - 2; i < j; j--)
            //     // {
            //     //     arr[j + 1] = arr[j];
            //     // }
            //     Array.Copy(arr, i + 1, arr, i + 2, arr.Length - i - 2);
            //     arr[i + 1] = 0;
            //     return true;
            // }
        }
    }
// @lc code=end

}
