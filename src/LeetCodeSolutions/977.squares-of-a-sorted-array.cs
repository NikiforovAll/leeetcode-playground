using System;
/*
 * @lc app=leetcode id=977 lang=csharp
 *
 * [977] Squares of a Sorted Array
 *
 * https://leetcode.com/problems/squares-of-a-sorted-array/description/
 *
 * algorithms
 * Easy (72.29%)
 * Likes:    1026
 * Dislikes: 82
 * Total Accepted:    211.9K
 * Total Submissions: 293.3K
 * Testcase Example:  '[-4,-1,0,3,10]'
 *
 * Given an array of integers A sorted in non-decreasing order, return an array
 * of the squares of each number, also in sorted non-decreasing order.
 *
 *
 *
 *
 * Example 1:
 *
 *
 * Input: [-4,-1,0,3,10]
 * Output: [0,1,9,16,100]
 *
 *
 *
 * Example 2:
 *
 *
 * Input: [-7,-3,2,3,11]
 * Output: [4,9,9,49,121]
 *
 *
 *
 *
 * Note:
 *
 *
 * 1 <= A.length <= 10000
 * -10000 <= A[i] <= 10000
 * A is sorted in non-decreasing order.
 *
 *
 *
 */
namespace _977
{
    // @lc code=start
    public class Solution
    {
        // sort of processed array
        // time: O(n) + O(n * log n) = O(n * log n)
        // space O(1)
        // public int[] SortedSquares(int[] A)
        // {
        //     for (int i = 0; i < A.Length; i++)
        //     {
        //         A[i] *= A[i];
        //     }
        //     Array.Sort(A);
        //     return A;
        // }

        // merge-sort solution
        //
        // no modification of initial array
        public int[] SortedSquares(int[] A)
        {
            var eol = 0;
            var length = A.Length;
            while (eol < length && A[eol] < 0) { eol++; }
            var res = new int[length];
            int i = eol - 1, j = eol, pos = 0;
            while (i >= 0 && j < length)
            {
                var left = A[i] * A[i];
                var right = A[j] * A[j];
                var min = Math.Min(left, right);
                _ = left < right ? i-- : j++;
                res[pos++] = min;
            }
            while (i >= 0)
            {
                res[pos++] = A[i] * A[i];
                i--;
            }
            while (j < length)
            {
                res[pos++] = A[j] * A[j];
                j++;
            }
            return res;
        }
        // Q: can we squeeze out some space by using in-place cyclic updates?
        // public int[] SortedSquares(int[] A)
        // {
        //     var p = 0;
        //     var length = A.Length;
        //     while (A[p] < 0 && p < length) { p++; }

        //     var j = p + 1;
        //     var i = p;
        //     while (i < j && j < length && i >= 0)
        //     {

        //     }
        // }


    }
    // @lc code=end
}

