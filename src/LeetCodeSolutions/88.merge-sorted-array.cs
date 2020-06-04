/*
 * @lc app=leetcode id=88 lang=csharp
 *
 * [88] Merge Sorted Array
 *
 * https://leetcode.com/problems/merge-sorted-array/description/
 *
 * algorithms
 * Easy (38.87%)
 * Likes:    2050
 * Dislikes: 3992
 * Total Accepted:    565.2K
 * Total Submissions: 1.5M
 * Testcase Example:  '[1,2,3,0,0,0]\n3\n[2,5,6]\n3'
 *
 * Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as
 * one sorted array.
 *
 * Note:
 *
 *
 * The number of elements initialized in nums1 and nums2 are m and n
 * respectively.
 * You may assume that nums1 has enough space (size that is greater or equal to
 * m + n) to hold additional elements from nums2.
 *
 *
 * Example:
 *
 *
 * Input:
 * nums1 = [1,2,3,0,0,0], m = 3
 * nums2 = [2,5,6],       n = 3
 *
 * Output: [1,2,2,3,5,6]
 *
 */
namespace _88
{

    // @lc code=start
    public class Solution
    {
        // shift, this way of traversal is not optimal
        // public void Merge(int[] nums1, int m, int[] nums2, int n)
        // {
        //     // p curr item in nums1_0[..m]
        //     // q curr item in nums2
        //     // pos curr index in result, nums1
        //     int p = 0, pos = 0, q = 0;
        //     while (pos < nums1.Length && q < n)
        //     {
        //         if (p < m && nums1[pos] <= nums2[q])
        //         {
        //             p++;
        //             pos++;
        //             continue;
        //         }
        //         else
        //         {
        //             for (int i = nums1.Length - 2; i >= pos; i--)
        //             {
        //                 nums1[i + 1] = nums1[i];
        //             }
        //             nums1[pos] = nums2[q++];
        //         }
        //         pos++;
        //     }
        // }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1, j = n - 1, pos = nums1.Length - 1;
            while (pos >= 0 && j >= 0)
            {
                nums1[pos--] = i >= 0 && nums1[i] > nums2[j]
                    ? nums1[i--]
                    : nums2[j--];
            }
        }
    }
    // @lc code=end
}

