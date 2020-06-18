<h1 align="center">
  Leetcode 👨‍💻
</h1>

# Leetcode-playground

![.NET Core](https://github.com/NikiforovAll/leetcode-playground/workflows/.NET%20Core/badge.svg)
[![codecov](https://codecov.io/gh/NikiforovAll/leetcode-playground/branch/master/graph/badge.svg)](https://codecov.io/gh/NikiforovAll/leetcode-playground-template)
[![GitHub License](https://img.shields.io/github/license/nikiforovall/leetcode-playground)](./LICENSE.md)

Leetcode url: <https://leetcode.com/nikiforovall/>

| # | Title | Solution | Basic idea (One line) |
|---| ----- | -------- | --------------------- |
| 1 | [Two Sum](https://leetcode.com/problems/two-sum/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/1.two-sum.cs) | 1. Hash O(n) and O(n) space.<br/>2. Sort O(n * log n) and search with two points O(n) and O(1) space.|
| 2 | [AddTwoNumbers](https://leetcode.com/problems/add-two-numbers/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/2.add-two-numbers.cs) | Traverse single-linked list and do modulo 10 sum |
| 15 | [3Sum](https://leetcode.com/problems/3sum/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/15.3-sum.cs) | Sort initial array, loop over array and pick current element, solve two-sum problem based on two pointers method for array to the right of current element with *target* equals to negated value of current element|
| 26 | [RemoveDuplicatesFromSortedArray](https://leetcode.com/articles/remove-duplicates-from-sorted-array/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/26.remove-duplicates-from-sorted-array.cs) | 1. Two pointers, slow/fast runner approach |
| 27 | [RemoveElement](https://leetcode.com/problems/remove-element/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/27.remove-element.cs) | Two pointers, skip element at the end and swap at the start. </br> |
| 35 | [SerachInsertPosition](https://leetcode.com/problems/search-insert-position/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/35.search-insert-position.cs) | 1. Two pointers, skip element at the end and swap at the start. </br> 2. Two pointers, both start at the beginning result-sub-list pointer and full-scan pointer |
| 69 | [SqrtX](https://leetcode.com/problems/sqrtx/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/src\LeetCodeSolutions\69.sqrt-x.cs) | Bisection, lazy curr element calculation f(mid) < x < f(mid+1), use division instead of multiplication to speed up calculation |
| 75 | [SortColors](https://leetcode.com/problems/sort-colors/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/src\LeetCodeSolutions\75.sort-colors.cs) | Two pointers approach, fill the rest of the array with 1 |
| 88 | [MergeSortedArray](https://leetcode.com/problems/3sum/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/88.merge-sorted-array.cs) | 1. Two pointers solution, store pointers to latest not processed in nums1, nums2 (=p,q). Shift nums1[pos..pos+m-p]->1 when item from nums2 is written and update p,q 2. Two pointers solution, start from the end to avoid shift operation|
| 130 | [SurroundedRegions](https://leetcode.com/problems/surrounded-regions) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/130.surrounded-regions.cs) | Traverse inner part of board and use dfs to check potential candidates for checking, commit if it is a valid group |
| 189 | [RotateArray](https://leetcode.com/problems/rotate-array) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/189.rotate-array.cs) | 1. Shifting with additional O(k) memory </br> 2. Reverse in-place based on pivot element </br> 3. Cyclic replacement |
| 200 | [NumberOfIslands](https://leetcode.com/problems/number-of-islands) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/200.number-of-islands.cs) | In-place uncheck of not visited islands via DFS/BFS |
| 231 | [PowerOfTwo](https://leetcode.com/problems/power-of-two) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/231.power-of-two.cs) | In-place uncheck of not visited islands via DFS/BFS |
| 275 | [HIndexII](https://leetcode.com/problems/h-index-ii) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/275.h-index-ii.cs) | Binary search for first A\[mid\] >= N - mind, return number of elements to the right of the pointer |
| 278 | [FirstBadVersion](https://leetcode.com/problems/first-bad-version) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/278.first-bad-version.cs) | Bisection |
| 380 | [InsertDeleteGetRandom1](https://leetcode.com/problems/insert-delete-getrandom-o1/description/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/380.insert-delete-get-random-o-1.cs) | Maintain map(val -> ind in array) + list, removal is based on swap of last element |
| 414 | [ThirdMaximumNumber](https://leetcode.com/problems/third-maximum-number/description/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/414.third-maximum-number.cs) | Three consecutive counters, stored element shift |
| 485 | [ValidateIPAddress](https://leetcode.com/problems/validate-ip-address/description/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/468.validate-ip-address.cs) | Validation pipeline with the list of heuristics |
| 485 | [MaxConsecutiveOnes](https://leetcode.com/problems/third-maximum-number/description/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/485.max-consecutive-ones.cs) | Sliding window for non-zero part of array and current sum calculation as index diff |
| 518 | [CoinChange2](https://leetcode.com/problems/coin-change-2) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/518.coin-change-2.cs) | Classic DP problem, cache total combinations of previous subproblems in a list |
| 547 | [FriendCircles](https://leetcode.com/problems/friend-circles) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/547.friend-circles.cs) | Checked DFS nodes |
| 904 | [FruitIntoBaskets](https://leetcode.com/problems/fruit-into-baskets) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/904.fruit-into-baskets.cs) | Sliding window, a bunch of pointers to store consecutive sequence of previous latest element |
| 977 | [SquaresOfASortedArray](https://leetcode.com/problems/squares-of-a-sorted-array) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/977.squares-of-a-sorted-array.cs) | 1. Merge sort, array with negative numbers is traversed in a reversed manner </br> 2. Two pointers |
| 1004 | [MaxConsecutiveOnesIII](https://leetcode.com/problems/max-consecutive-ones-iii) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/1004.max-consecutive-ones-iii.cs) | Sliding window, remove elements from the tail |
| 1004 | [TwoCityScheduling](https://leetcode.com/problems/two-city-scheduling) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/1029.two-city-scheduling.cs) | Greedy solution based on costs difference heuristic + sorting |
| 1114 | [DuplicateZeros](https://leetcode.com/problems/duplicate-zeros/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/1089.duplicate-zeros.cs) | Implement array shift starting from the end for each zero element, don't forget to skip updated zero |
| 1114 | [FirstInOrder](https://leetcode.com/problems/print-in-order/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/1114.print-in-order.cs) | Event-based blocking ManualResetEventSlim |
| 1115 | [PrintFooBarAlternately](https://leetcode.com/problems/print-foobar-alternately/description/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/1115.print-foo-bar-alternately.cs) | Event-based blocking ManualResetEventSlim |
| 1295 | [FindNumbersWithEvenNumberOfDigits](https://leetcode.com/problems/find-numbers-with-even-number-of-digits) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/1295.find-numbers-with-even-number-of-digits.cs) | Reduce arr item to double digit by dividing by 100 and count |

## Other Leetcode Repos

1. <https://github.com/tangweikun/awesome-leetcode>
2. [haoel's leetcode](https://github.com/haoel/leetcode)
3. [soulmachine's leetcode](https://github.com/soulmachine/leetcode)
4. [gouthampradhan's leetcode](https://github.com/gouthampradhan/leetcode)
5. [qiyuangong's leetcode](https://github.com/qiyuangong/leetcode)
