/*
 * @lc app=leetcode id=459 lang=csharp
 *
 * [459] Repeated Substring Pattern
 *
 * https://leetcode.com/problems/repeated-substring-pattern/description/
 *
 * algorithms
 * Easy (42.05%)
 * Likes:    1704
 * Dislikes: 161
 * Total Accepted:    136.8K
 * Total Submissions: 322.9K
 * Testcase Example:  '"abab"'
 *
 * Given a non-empty string check if it can be constructed by taking a
 * substring of it and appending multiple copies of the substring together. You
 * may assume the given string consists of lowercase English letters only and
 * its length will not exceed 10000.
 *
 *
 *
 * Example 1:
 *
 *
 * Input: "abab"
 * Output: True
 * Explanation: It's the substring "ab" twice.
 *
 *
 * Example 2:
 *
 *
 * Input: "aba"
 * Output: False
 *
 *
 * Example 3:
 *
 *
 * Input: "abcabcabcabc"
 * Output: True
 * Explanation: It's the substring "abc" four times. (And the substring
 * "abcabc" twice.)
 *
 *
 */
using System;
using System.Linq;
namespace _459
{

    // @lc code=start
    public class Solution
    {
        public bool RepeatedSubstringPattern(string s)
        {
            ReadOnlySpan<char> source = s;
            var bucket_size = 1;
            var length = s.Length;
            while (bucket_size < length)
            {
                if (length % bucket_size == 0)
                {
                    if (source.Unanimous(bucket_size))
                        return true;
                }
                bucket_size++;
            }
            return false;
        }


    }
    public static class SpanExtensions
    {
        public static bool Unanimous<T>(this ReadOnlySpan<T> source, int bucket_size)
            where T : IEquatable<T>
        {
            var start = 0;
            var end = start + bucket_size;
            var first = source[..bucket_size];
            while (end <= source.Length)
            {
                var sequence = source[start..end];
                start += bucket_size;
                end += bucket_size;
                if (!sequence.SequenceEqual(first))
                    return false;
            }
            return true;
        }
    }
    // @lc code=end
}
