using System;
using System.Collections.Generic;
/*
* @lc app=leetcode id=220 lang=csharp
*
* [220] Contains Duplicate III
*
* https://leetcode.com/problems/contains-duplicate-iii/description/
*
* algorithms
* Medium (20.75%)
* Likes:    1118
* Dislikes: 1193
* Total Accepted:    128.7K
* Total Submissions: 614.5K
* Testcase Example:  '[1,2,3,1]\n3\n0'
*
* Given an array of integers, find out whether there are two distinct indices
* i and j in the array such that the absolute difference between nums[i] and
* nums[j] is at most t and the absolute difference between i and j is at most
* k.
*
*
* Example 1:
*
*
* Input: nums = [1,2,3,1], k = 3, t = 0
* Output: true
*
*
*
* Example 2:
*
*
* Input: nums = [1,0,1,1], k = 1, t = 2
* Output: true
*
*
*
* Example 3:
*
*
* Input: nums = [1,5,9,1,5,9], k = 2, t = 3
* Output: false
*
*
*
*
*/
namespace _220
{

    // @lc code=start
    public class Solution
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            var length = nums.Length - 1;
            k = length < k ? length : k;
            // sliding to the right
            for (int i = 0; i < nums.Length - k; i++)
            {
                // * consider to use insertion sort to optimize
                var arr = nums[i..(i + k + 1)];
                GroomArray();
                // Array.Sort(arr);
                if (Check(arr, t))
                    return true;
                void GroomArray()
                {
                    if (i == 0)
                    {
                        Array.Sort(arr);
                    }
                    else
                    {
                        Insert(arr, nums[i + k]);
                    }
                }
            }
            return false;

        }

        /// <summary>
        /// Finds almost duplicates in a sorted span<T>
        /// </summary>
        /// <param name="source">Sorted memory</param>
        /// <param name="diff"></param>
        /// <returns></returns>
        private bool Check(Span<int> source, int diff)
        {
            long min = long.MaxValue;
            for (var i = 0; i < source.Length - 1; i++)
            {
                var localDiff = (long)source[i] - source[i + 1];
                localDiff = Math.Abs(localDiff);
                min = localDiff < min ? localDiff : min;
            }
            return min <= diff;
        }

        private void Insert(Span<int> source, int val)
        {
            // var foundInd = source.BinarySearch(
            //     val,
            //     Comparer<int>.Create((x, y) => x >= y ? 1 : -1));
            var foundInd = 0;
            var length = source.Length;
            while (foundInd < length && source[foundInd] <= val)
            {
                foundInd++;
            }
            foundInd--;
            if(foundInd < length)
            {
                source[foundInd..^1].CopyTo(source[(foundInd + 1)..]);
                source[foundInd] = val;
            }
            // Array.Copy(source, foundInd, source, foundInd + 1, source.Length - 1);
        }

    }
    // @lc code=end

}
