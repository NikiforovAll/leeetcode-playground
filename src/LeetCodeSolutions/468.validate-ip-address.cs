/*
 * @lc app=leetcode id=468 lang=csharp
 *
 * [468] Validate IP Address
 *
 * https://leetcode.com/problems/validate-ip-address/description/
 *
 * algorithms
 * Medium (22.42%)
 * Likes:    239
 * Dislikes: 1267
 * Total Accepted:    50.9K
 * Total Submissions: 224.7K
 * Testcase Example:  '"172.16.254.1"'
 *
 *
 * Write a function to check whether an input string is a valid IPv4 address or
 * IPv6 address or neither.
 *
 *
 *
 * IPv4 addresses are canonically represented in dot-decimal notation, which
 * consists of four decimal numbers, each ranging from 0 to 255, separated by
 * dots ("."), e.g.,172.16.254.1;
 *
 *
 *
 * Besides, leading zeros in the IPv4 is invalid. For example, the address
 * 172.16.254.01 is invalid.
 *
 *
 *
 * IPv6 addresses are represented as eight groups of four hexadecimal digits,
 * each group representing 16 bits. The groups are separated by colons (":").
 * For example, the address 2001:0db8:85a3:0000:0000:8a2e:0370:7334 is a valid
 * one. Also, we could omit some leading zeros among four hexadecimal digits
 * and some low-case characters in the address to upper-case ones, so
 * 2001:db8:85a3:0:0:8A2E:0370:7334 is also a valid IPv6 address(Omit leading
 * zeros and using upper cases).
 *
 *
 *
 *
 * However, we don't replace a consecutive group of zero value with a single
 * empty group using two consecutive colons (::) to pursue simplicity. For
 * example, 2001:0db8:85a3::8A2E:0370:7334 is an invalid IPv6 address.
 *
 *
 *
 * Besides, extra leading zeros in the IPv6 is also invalid. For example, the
 * address 02001:0db8:85a3:0000:0000:8a2e:0370:7334 is invalid.
 *
 *
 *
 * Note:
 * You may assume there is no extra space or special characters in the input
 * string.
 *
 *
 * Example 1:
 *
 * Input: "172.16.254.1"
 *
 * Output: "IPv4"
 *
 * Explanation: This is a valid IPv4 address, return "IPv4".
 *
 *
 *
 *
 * Example 2:
 *
 * Input: "2001:0db8:85a3:0:0:8A2E:0370:7334"
 *
 * Output: "IPv6"
 *
 * Explanation: This is a valid IPv6 address, return "IPv6".
 *
 *
 *
 * Example 3:
 *
 * Input: "256.256.256.256"
 *
 * Output: "Neither"
 *
 * Explanation: This is neither a IPv4 address nor a IPv6 address.
 *
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace _468
{

    // @lc code=start
    public class Solution
    {
        public const string INVALID = "Neither";
        public string ValidIPAddress(string IP)
        {
            var calc = ClassifierFactory.Create(IP);
            return calc.Choose(IP);
        }
    }
    public interface IClassifier
    {
        string Choose(string input);
    }

    public class ClassifierFactory
    {
        public static IClassifier Create(string input) =>
            input.Contains(".")
                ? new IPV4Classifier() as IClassifier
                : new IPV6Classifier();
    }
    public class IPV4Classifier : IClassifier
    {
        public string Choose(string input)
        {
            var tokens = new Parser().Parse('.', input);

            var pipeline = new List<Predicate<string>>(){
            (token) => !token.StartsWith("0") && !token.StartsWith("-") || token == "0",
            (token) => int.TryParse(token, out var num)
                && num >= 0 && num < 256
            };
            return tokens.Length == 4
                && tokens.All(t => pipeline.All(p => p.Invoke(t)))
                    ? "IPv4"
                    : Solution.INVALID;
        }
    }
    public class IPV6Classifier : IClassifier
    {
        public string Choose(string input)
        {
            var tokens = new Parser().Parse(':', input);
            var pipeline = new List<Predicate<string>>(){
            (token) => token.Length < 5,
            (token) => uint.TryParse(
                token, System.Globalization.NumberStyles.HexNumber, null, out var _)
            };

            return tokens.Length == 8
                && tokens.All(t => pipeline.All(p => p.Invoke(t)))
                    ? "IPv6"
                    : Solution.INVALID;
        }
    }
    public class Parser
    {
        public string[] Parse(char sep, string input) => input.Split(sep);
    }
    // @lc code=end
}

