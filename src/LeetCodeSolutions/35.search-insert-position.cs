/*
 * @lc app=leetcode id=35 lang=csharp
 *
 * [35] Search Insert Position
 *
 * https://leetcode.com/problems/search-insert-position/description/
 *
 * algorithms
 * Easy (41.69%)
 * Likes:    2200
 * Dislikes: 245
 * Total Accepted:    588.4K
 * Total Submissions: 1.4M
 * Testcase Example:  '[1,3,5,6]\n5'
 *
 * Given a sorted array and a target value, return the index if the target is
 * found. If not, return the index where it would be if it were inserted in
 * order.
 *
 * You may assume no duplicates in the array.
 *
 * Example 1:
 *
 *
 * Input: [1,3,5,6], 5
 * Output: 2
 *
 *
 * Example 2:
 *
 *
 * Input: [1,3,5,6], 2
 * Output: 1
 *
 *
 * Example 3:
 *
 *
 * Input: [1,3,5,6], 7
 * Output: 4
 *
 *
 * Example 4:
 *
 *
 * Input: [1,3,5,6], 0
 * Output: 0
 *
 *
 */
namespace _35
{

    // @lc code=start
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int i = 0, j = nums.Length - 1;
            while (i <= j)
            {
                var mid = i + (j - i) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target && (mid >= nums.Length - 1 || target < nums[mid + 1]))
                {
                    return mid + 1;
                }
                else if (nums[mid] > target)
                {
                    j = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    i = mid + 1;
                }
            }
            return 0;
        }
    }
    // @lc code=end
}
