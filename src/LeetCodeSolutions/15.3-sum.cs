using System;
using System.Linq;
using System.Collections.Generic;
/*
 * @lc app=leetcode id=15 lang=csharp
 *
 * [15] 3Sum
 *
 * https://leetcode.com/problems/3sum/description/
 *
 * algorithms
 * Medium (26.18%)
 * Likes:    6531
 * Dislikes: 784
 * Total Accepted:    877.5K
 * Total Submissions: 3.4M
 * Testcase Example:  '[-1,0,1,2,-1,-4]'
 *
 * Given an array nums of n integers, are there elements a, b, c in nums such
 * that a + b + c = 0? Find all unique triplets in the array which gives the
 * sum of zero.
 *
 * Note:
 *
 * The solution set must not contain duplicate triplets.
 *
 * Example:
 *
 *
 * Given array nums = [-1, 0, 1, 2, -1, -4],
 *
 * A solution set is:
 * [
 * ⁠ [-1, 0, 1],
 * ⁠ [-1, -1, 2]
 * ]
 *
 *
 */
namespace _15
{
    // @lc code=start
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var res = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int low = i + 1, high = nums.Length - 1;
                while (low < high)
                {
                    var sum = nums[low] + nums[high];
                    if (sum + nums[i] == 0)
                    {
                        var isUnique = true;
                        for (int j = res.Count - 1; j >= 0 && nums[i] == res[j][0]; j--)
                        {
                            var lr = res[j];
                            if ((nums[i], nums[low], nums[high]) == (lr[0], lr[1], lr[2]))
                            {
                                isUnique = false;
                                break;
                            }
                        }
                        if(isUnique)
                            res.Add(new int[] { nums[i], nums[low], nums[high] });
                        low++;
                        high--;
                    }
                    else if (sum > -nums[i])
                    {
                        high--;
                    }
                    else
                    {
                        low++;
                    }
                }
            }
            return res;
        }
    }
    // @lc code=end


    // Solutions below is correct but exceeds time limit, it is not brute force based solution, but still not fast enough to compete with algorithm on sorted arrays
    // time limit on: [-5,1,-10,2,-7,-13,-3,-8,2,-15,9,-3,-15,13,-6,-10,5,6,11,1,13,-12,14,6,11,4,13,-14,0,11,1,10,-11,6,-11,-10,8,2,-3,-13,-6,-9,-9,-6,11,-8,-9,1,13,9,9,3,13,0,-6,1,-10,-15,3,5,3,11,-8,0,2,-11,5,-13,6,9,-11,7,8,-13,8,4,-6,14,13,-15,1,7,-5,-1,-7,5,7,-2,-3,-13,10,7,13,9,-8,-8,13,12,-6,4,7,-10,-12,-8,-8,11,11,-6,3,9,-14,-11,2,-4,-5,10,8,-13,-7,12,-10,10]
    // public IList<IList<int>> ThreeSum(int[] nums)
    // {
    //     var res = new List<IList<int>>();
    //     for (var i = 0; i < nums.Length; i++)
    //     {
    //         var curr = nums[i];
    //         var except = new Dictionary<int, int>
    //         {
    //             [curr] = 1
    //         };
    //         var allFound = new List<int> { curr };
    //         while (TwoSumExcept(nums, -curr, except, out var found))
    //         {
    //             found[2] = nums[i];

    //             allFound.AddRange(found);
    //             allFound.Remove(curr);
    //             except = allFound.GroupBy(i => i)
    //                 .ToDictionary(e => e.Key, e => e.Count());
    //             Array.Sort(found);
    //             var isNew = true;
    //             foreach (var lr in res)
    //             {
    //                 if ((lr[0], lr[1], lr[2]) == (found[0], found[1], found[2]))
    //                 {
    //                     isNew = false;
    //                     break;
    //                 }
    //             }
    //             if (isNew)
    //             {
    //                 res.Add(found);
    //             }
    //         }
    //     }
    //     return res;
    // }

    // private bool TwoSumExcept(int[] nums, int target, Dictionary<int, int> except, out int[] res)
    // {
    //     var comp = new Dictionary<int, int>();
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         var curr = nums[i];
    //         if (except.ContainsKey(curr) && except[curr] > 0)
    //         {
    //             except[curr]--;
    //             continue;
    //         }
    //         if (comp.ContainsKey(curr))
    //         {
    //             res = new int[] { curr, comp[curr], int.MinValue };
    //             return true;
    //         }
    //         comp[target - curr] = curr;
    //     }
    //     res = null;
    //     return false;
    // }
    // [-4,-2,-2,-2,0,1,2,2,2,3,3,4,4,6,6]
    // [-4,-2,1,-5,-4,-4,4,-2,0,4,0,-2,3,1,-5,0]
    // [-2,0,3,-1,4,0,3,4,1,1,1,-3,-5,4,0]
}
