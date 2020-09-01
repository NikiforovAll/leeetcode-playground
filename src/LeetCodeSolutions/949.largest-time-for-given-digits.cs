using System;
using System.Collections;
/*
* @lc app=leetcode id=949 lang=csharp
*
* [949] Largest Time for Given Digits
*
* https://leetcode.com/problems/largest-time-for-given-digits/description/
*
* algorithms
* Easy (36.39%)
* Likes:    214
* Dislikes: 438
* Total Accepted:    21.3K
* Total Submissions: 59.7K
* Testcase Example:  '[1,2,3,4]'
*
* Given an array of 4 digits, return the largest 24 hour time that can be
* made.
*
* The smallest 24 hour time is 00:00, and the largest is 23:59.  Starting from
* 00:00, a time is larger if more time has elapsed since midnight.
*
* Return the answer as a string of length 5.  If no valid time can be made,
* return an empty string.
*
*
*
*
* Example 1:
*
*
* Input: [1,2,3,4]
* Output: "23:41"
*
*
*
* Example 2:
*
*
* Input: [5,5,5,5]
* Output: ""
*
*
*
*
* Note:
*
*
* A.length == 4
* 0 <= A[i] <= 9
*
*
*
*/

using System.Collections.Generic;
using System.Linq;

namespace _949
{
    // @lc code=start

    using Constraint = System.Func<int, bool>;
    public class Solution
    {
        public string LargestTimeFromDigits(int[] A)
        {
            var max = "";
            foreach (var perm in Permutations(A))
            {
                var res = LargestTimeFromSource(perm.ToList());
                max = max.CompareTo(res) == 1 ? max : res;
            }
            return max;
        }

        public string LargestTimeFromSource(IList<int> source)
        {
            var result = new List<int>(4);
            var dtree = new Decision(
                val => (val switch
                {
                    var num when num < 2 => new Decision(
                        (_) => new Decision() { e => e >= 0 && e <= 5 }
                    ) { e => e >= 0 && e <= 9 },
                    2 => new Decision(
                        (_) => new Decision() { e => e >= 0 && e <= 5 }
                    ) { e => e >= 0 && e <= 3 },
                })) { e => e >= 0 && e <= 2 };
            while (source.Any())
            {
                try
                {
                    if (dtree is null)
                    {
                        // default detached constraint
                        dtree = new Decision() { e => e >= 0 && e <= 9 };
                    }
                    var constraint = dtree.First();
                    var elem = source.First(constraint);
                    dtree.Evaluate(elem);
                    dtree = dtree.Result;
                    source.Remove(elem);
                    result.Add(elem);
                }
                catch
                {
                    return "";
                }

            }
            return $"{string.Concat(result.Take(2))}:{string.Concat(result.Skip(2))}";
        }


        public class Decision : IEnumerable<Constraint>
        {
            public Decision Result { get; set; }
            public Func<int, Decision> Pick { get; }
            public IList<Constraint> Context { get; private set; } = new List<Constraint>();

            public Decision(Func<int, Decision> pick = default)
            {
                Pick = pick;
            }
            public void Evaluate(int value)
            {
                Result = Pick?.Invoke(value);
            }

            public void Add(Constraint constraint)
            {
                Context.Add(constraint);
            }

            public IEnumerator<Constraint> GetEnumerator() => Context.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => Context.GetEnumerator();
        }

        public static IEnumerable<T[]> Permutations<T>(T[] values, int fromInd = 0)
        {
            if (fromInd + 1 == values.Length)
                yield return values;
            else
            {
                foreach (var v in Permutations(values, fromInd + 1))
                    yield return v;

                for (var i = fromInd + 1; i < values.Length; i++)
                {
                    SwapValues(values, fromInd, i);
                    foreach (var v in Permutations(values, fromInd + 1))
                        yield return v;
                    SwapValues(values, fromInd, i);
                }
            }
        }

        private static void SwapValues<T>(T[] values, int pos1, int pos2)
        {
            if (pos1 != pos2)
            {
                T tmp = values[pos1];
                values[pos1] = values[pos2];
                values[pos2] = tmp;
            }
        }
    }
    // @lc code=end
}

