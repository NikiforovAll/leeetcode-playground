using System;
using System.Collections.Generic;
using System.Linq;
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
    // n log k
    public class Solution
    {
        private readonly SortedSet<long> neighbors = new SortedSet<long>();

        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            if (k < 0 || t < 0) return false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (IsThereNeighbor(nums[i], t)) return true;
                neighbors.Add(nums[i]);
                if (i >= k) neighbors.Remove(nums[i - k]);
            }
            return false;
        }

        private bool IsThereNeighbor(long num, int distance)
        {
            return neighbors.GetViewBetween(num - distance, num + distance).Any();
        }
    }
    // @lc code=end
    // O(k*log k + (n - k)*(k+k))
    public class Solution2
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            var length = nums.Length - 1;
            // Span<int> numsSpan = nums;
            // tmpArr.CopyTo(arr);
            k = length < k ? length : k;
            var sorted = nums[..(k + 1)]
                .OrderBy(i => i)
                .ToList();
            for (var i = 0; i < nums.Length - k; i++)
            {
                if (i > 0)
                {
                    sorted.Remove(nums[i - 1]);
                    Insert(sorted, nums[i + k]);
                }
                if (Check(sorted, t))
                    return true;

            }
            return false;

        }

        /// <summary>
        /// Finds almost duplicates in a sorted span<T>
        /// </summary>
        /// <param name="source">Sorted memory</param>
        /// <param name="diff"></param>
        /// <returns></returns>
        private bool Check(IList<int> source, int diff)
        {
            long min = long.MaxValue;
            for (var i = 0; i < source.Count - 1; i++)
            {
                var localDiff = (long)source[i] - source[i + 1];
                localDiff = Math.Abs(localDiff);
                min = localDiff < min ? localDiff : min;
            }
            return min <= diff;
        }

        private void Insert<T>(IList<T> items, T val)
            where T : IComparable
        {
            var foundInd = 0;
            var length = items.Count;
            while (foundInd < length && items[foundInd].CompareTo(val) != 1)
            {
                foundInd++;
            }
            items.Insert(foundInd, val);
        }

        // in place insertion
        // private void Insert(Span<int> source, int val)
        // {
        //     // var foundInd = source.BinarySearch(
        //     //     val,
        //     //     Comparer<int>.Create((x, y) => x >= y ? 1 : -1));
        //     var foundInd = 0;
        //     var length = source.Length;
        //     while (foundInd < length && source[foundInd] <= val)
        //     {
        //         foundInd++;
        //     }
        //     if (foundInd < length)
        //     {
        //         source[foundInd..^1].CopyTo(source[(foundInd + 1)..]);
        //         source[foundInd] = val;
        //     }
        //     // Array.Copy(source, foundInd, source, foundInd + 1, source.Length - 1);
        // }

    }

}
