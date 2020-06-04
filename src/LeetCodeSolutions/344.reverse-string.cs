/*
 * @lc app=leetcode id=344 lang=csharp
 *
 * [344] Reverse String
 *
 * https://leetcode.com/problems/reverse-string/description/
 *
 * algorithms
 * Easy (66.76%)
 * Likes:    1311
 * Dislikes: 666
 * Total Accepted:    687.9K
 * Total Submissions: 1M
 * Testcase Example:  '["h","e","l","l","o"]'
 *
 * Write a function that reverses a string. The input string is given as an
 * array of characters char[].
 *
 * Do not allocate extra space for another array, you must do this by modifying
 * the input array in-place with O(1) extra memory.
 *
 * You may assume all the characters consist of printable ascii
 * characters.
 *
 *
 *
 *
 * Example 1:
 *
 *
 * Input: ["h","e","l","l","o"]
 * Output: ["o","l","l","e","h"]
 *
 *
 *
 * Example 2:
 *
 *
 * Input: ["H","a","n","n","a","h"]
 * Output: ["h","a","n","n","a","H"]
 *
 *
 *
 *
 */

namespace _344
{
    // @lc code=start
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            int left = 0, right = s.Length - 1;
            while (left < right)
                (s[left], s[right]) = (s[right--], s[left++]);
        }
    }
    // public class Solution
    // {
    //     public void ReverseString(char[] s)
    //     {
    //         for (int i = 0; i < s.Length / 2; i++)
    //         {
    //             ref var l = ref s[i];
    //             ref var r = ref s[s.Length - 1 - i];
    //             (l, r) = (r, l);
    //         }
    //     }
    // }
    // @lc code=end
}

