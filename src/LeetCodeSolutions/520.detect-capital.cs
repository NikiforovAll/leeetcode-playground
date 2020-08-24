/*
 * @lc app=leetcode id=520 lang=csharp
 *
 * [520] Detect Capital
 *
 * https://leetcode.com/problems/detect-capital/description/
 *
 * algorithms
 * Easy (53.20%)
 * Likes:    642
 * Dislikes: 278
 * Total Accepted:    169.4K
 * Total Submissions: 314.3K
 * Testcase Example:  '"USA"'
 *
 * Given a word, you need to judge whether the usage of capitals in it is right
 * or not.
 *
 * We define the usage of capitals in a word to be right when one of the
 * following cases holds:
 *
 *
 * All letters in this word are capitals, like "USA".
 * All letters in this word are not capitals, like "leetcode".
 * Only the first letter in this word is capital, like "Google".
 *
 * Otherwise, we define that this word doesn't use capitals in a right way.
 *
 *
 *
 * Example 1:
 *
 *
 * Input: "USA"
 * Output: True
 *
 *
 *
 *
 * Example 2:
 *
 *
 * Input: "FlaG"
 * Output: False
 *
 *
 *
 *
 * Note: The input will be a non-empty word consisting of uppercase and
 * lowercase latin letters.
 *
 */
using System;
using System.Linq;

namespace _520
{

    // @lc code=start
    public class Solution
    {
        public bool DetectCapitalUse(string word) =>
            (first: word.FirstOrDefault(), other: word.Skip(1)) switch {
                var (first, other) when char.IsUpper(first) =>
                    other.All(char.IsUpper) || other.All(char.IsLower),
                var (first, other) when char.IsLower(first) =>
                    other.All(char.IsLower),
            };
    }
    // @lc code=end

}
