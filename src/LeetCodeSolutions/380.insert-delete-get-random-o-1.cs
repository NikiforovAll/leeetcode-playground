using System;
using System.Collections.Generic;
/*
 * @lc app=leetcode id=380 lang=csharp
 *
 * [380] Insert Delete GetRandom O(1)
 *
 * https://leetcode.com/problems/insert-delete-getrandom-o1/description/
 *
 * algorithms
 * Medium (46.20%)
 * Likes:    2210
 * Dislikes: 143
 * Total Accepted:    208.3K
 * Total Submissions: 446.6K
 * Testcase Example:  '["RandomizedSet","insert","remove","insert","getRandom","remove","insert","getRandom"]\n' +
  '[[],[1],[2],[2],[],[1],[2],[]]'
 *
 * Design a data structure that supports all following operations in average
 * O(1) time.
 *
 *
 *
 * insert(val): Inserts an item val to the set if not already present.
 * remove(val): Removes an item val from the set if present.
 * getRandom: Returns a random element from current set of elements. Each
 * element must have the same probability of being returned.
 *
 *
 *
 * Example:
 *
 * // Init an empty set.
 * RandomizedSet randomSet = new RandomizedSet();
 *
 * // Inserts 1 to the set. Returns true as 1 was inserted successfully.
 * randomSet.insert(1);
 *
 * // Returns false as 2 does not exist in the set.
 * randomSet.remove(2);
 *
 * // Inserts 2 to the set, returns true. Set now contains [1,2].
 * randomSet.insert(2);
 *
 * // getRandom should return either 1 or 2 randomly.
 * randomSet.getRandom();
 *
 * // Removes 1 from the set, returns true. Set now contains [2].
 * randomSet.remove(1);
 *
 * // 2 was already in the set, so return false.
 * randomSet.insert(2);
 *
 * // Since 2 is the only number in the set, getRandom always return 2.
 * randomSet.getRandom();
 *
 *
 */
namespace _380
{

    // @lc code=start
    public class RandomizedSet
    {
        private readonly Dictionary<int, int> dict = new Dictionary<int, int>();
        private readonly List<int> list = new List<int>();
        private readonly Random r = new Random();

        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {
            if (dict.TryAdd(val, list.Count))
            {
                list.Add(val);
                return true;
            }
            return false;
        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {
            if (!dict.ContainsKey(val))
            {
                return false;
            }
            dict.Remove(val, out var ind);
            var lastInd = list.Count - 1;
            var last = list[lastInd];
            list.RemoveAt(lastInd);
            if (ind != lastInd)
            {
                list[ind] = last;
                dict[last] = ind;
            }
            return true;
        }

        /** Get a random element from the set. */
        public int GetRandom()
            => list[r.Next(list.Count)];
    }

    /**
     * Your RandomizedSet object will be instantiated and called as such:
     * RandomizedSet obj = new RandomizedSet();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
    // @lc code=end

}
