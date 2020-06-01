/*
 * @lc app=leetcode id=189 lang=csharp
 *
 * [189] Rotate Array
 *
 * https://leetcode.com/problems/rotate-array/description/
 *
 * algorithms
 * Easy (33.94%)
 * Likes:    2583
 * Dislikes: 783
 * Total Accepted:    467.1K
 * Total Submissions: 1.4M
 * Testcase Example:  '[1,2,3,4,5,6,7]\n3'
 *
 * Given an array, rotate the array to the right by k steps, where k is
 * non-negative.
 *
 * Follow up:
 *
 *
 * Try to come up as many solutions as you can, there are at least 3 different
 * ways to solve this problem.
 * Could you do it in-place with O(1) extra space?
 *
 *
 *
 * Example 1:
 *
 *
 * Input: nums = [1,2,3,4,5,6,7], k = 3
 * Output: [5,6,7,1,2,3,4]
 * Explanation:
 * rotate 1 steps to the right: [7,1,2,3,4,5,6]
 * rotate 2 steps to the right: [6,7,1,2,3,4,5]
 * rotate 3 steps to the right: [5,6,7,1,2,3,4]
 *
 *
 * Example 2:
 *
 *
 * Input: nums = [-1,-100,3,99], k = 2
 * Output: [3,99,-1,-100]
 * Explanation:
 * rotate 1 steps to the right: [99,-1,-100,3]
 * rotate 2 steps to the right: [3,99,-1,-100]
 *
 *
 *
 * Constraints:
 *
 *
 * 1 <= nums.length <= 2 * 10^4
 * It's guaranteed that nums[i] fits in a 32 bit-signed integer.
 * k >= 0
 *
 *
 */

using System;
namespace _189
{
    // @lc code=start
    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            Solution3(nums, k);
        }

        // use additional O(k) space to store prefix
        // shift elements in a linear time and restore prefix
        private void Solution1(int[] nums, int k)
        {
            var shift = k % nums.Length;
            var prefix = new int[shift];
            for (int i = 0; i < shift; i++)
            {
                prefix[i] = nums[nums.Length - shift + i];
            }
            for (int i = nums.Length - 1; i >= shift; i--)
            {
                nums[i] = nums[i - shift];
            }
            for (int i = 0; i < shift; i++)
            {
                nums[i] = prefix[i];
            }
        }
        // in-place solution
        // time-out O(n x k)
        private void Solution0(int[] nums, int k)
        {
            for (int i = 0; i < k; i++)
            {
                Shift();
            }
            void Shift()
            {
                var prefix = nums[^1];
                for (int i = nums.Length - 1; i > 0; i--)
                {
                    nums[i] = nums[i - 1];
                }
                nums[0] = prefix;
            }
        }

        private void Solution3(int[] nums, int k)
        {
            int pivot = k % nums.Length;
            var length = nums.Length - 1;
            ReverseSubArray(nums, 0, length);
            ReverseSubArray(nums, 0, pivot - 1);
            ReverseSubArray(nums, pivot, length);
            // Reverse(nums);
            // Reverse(nums.AsSpan(0, pivot));
            // Reverse(nums.AsSpan(pivot));
            // static void Reverse(Span<int> arr)
            // {
            //     var length = arr.Length - 1;
            //     for (int i = 0; i < arr.Length / 2; i++)
            //     {
            //         (arr[i], arr[length - i]) = (arr[length - i], arr[i]);
            //     }
            // }
            static void ReverseSubArray(int[] arr, int start, int end)
            {
                while (start < end)
                {
                    (arr[start], arr[end]) = (arr[end], arr[start]);
                    start++;
                    end--;
                }
            }
            // static void ReverseSubArray(int[] arr, int start, int end)
            // {
            //     var pivot = start + (end - start) / 2;
            //     var length = end - start - 1;
            //     for (int i = start; i <= pivot; i++)
            //     {
            //         (arr[i], arr[end - i + start]) = (arr[end - i + start], arr[i]);
            //     }
            // }
        }

        // Cyclic replacement
        private void Solution4(int[]nums, int k)
        {
            k %= nums.Length;
            var count = 0;
            for (int start = 0; count < nums.Length; start++)
            {
                var current = start;
                var prev = nums[start];
                do
                {
                    var next = (current + k) % nums.Length;
                    var temp = nums[next];
                    nums[next] = prev;
                    prev = temp;
                    count++;
                } while (start != current);
            }
        }
    }
    // @lc code=end
}
