/*
 * @lc app=leetcode id=125 lang=csharp
 *
 * [125] Valid Palindrome
 *
 * https://leetcode.com/problems/valid-palindrome/description/
 *
 * algorithms
 * Easy (35.29%)
 * Likes:    1358
 * Dislikes: 3094
 * Total Accepted:    662.6K
 * Total Submissions: 1.8M
 * Testcase Example:  '"A man, a plan, a canal: Panama"'
 *
 * Given a string, determine if it is a palindrome, considering only
 * alphanumeric characters and ignoring cases.
 *
 * Note: For the purpose of this problem, we define empty string as valid
 * palindrome.
 *
 * Example 1:
 *
 *
 * Input: "A man, a plan, a canal: Panama"
 * Output: true
 *
 *
 * Example 2:
 *
 *
 * Input: "race a car"
 * Output: false
 *
 *
 *
 * Constraints:
 *
 *
 * s consists only of printable ASCII characters.
 *
 *
 */

namespace _125
{
    // @lc code=start
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                if(!char.IsLetterOrDigit(s[i]))
                {
                    i++;
                    continue;
                }
                if(!char.IsLetterOrDigit(s[j])){
                    j--;
                    continue;
                }

                if (char.ToUpperInvariant(s[i++]) != char.ToUpperInvariant(s[j--]))
                    return false;
            }
            return true;
        }
    }
    // @lc code=end
}

