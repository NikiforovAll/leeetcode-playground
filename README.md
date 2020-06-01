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
| 1 | [Two Sum](https://leetcode.com/problems/two-sum/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/1.two-sum.cs) | 1. Hash O(n) and O(n) space.<br/>2. Sort and search with two points O(n) and O(1) space. |
| 15 | [3Sum](https://leetcode.com/problems/3sum/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/15.3-sum.cs) | Sort initial array, loop over array and pick current element, solve two-sum problem based on two pointers method for array to the right of current element with *target* equals to negated value of current element|
| 189 | [RotateArray](https://leetcode.com/problems/rotate-array) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/189.rotate-array.cs) | 1. Shifting with additional O(k) memory </br> 2. Reverse in-place based on pivot element </br> 3. Cyclic replacement |
| 200 | [NumberOfIslands](https://leetcode.com/problems/number-of-islands) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/200.number-of-islands.cs) | In-place uncheck of not visited islands via DFS/BFS |
| 278 | [FirstBadVersion](https://leetcode.com/problems/first-bad-version) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/278.first-bad-version.cs) | Bisection |
| 414 | [ThirdMaximumNumber](https://leetcode.com/problems/third-maximum-number/description/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/414.third-maximum-number.cs) | Three consecutive counters, stored element shift |
| 547 | [FriendCircles](https://leetcode.com/problems/friend-circles) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/547.friend-circles.cs) | Checked DFS nodes |
| 1004 | [FruitIntoBaskets](https://leetcode.com/problems/fruit-into-baskets) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/904.fruit-into-baskets.cs) | Sliding window, a bunch of pointers to store consecutive sequence of previous latest element |
| 1004 | [MaxConsecutiveOnesIII](https://leetcode.com/problems/max-consecutive-ones-iii) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/1004.max-consecutive-ones-iii.cs) | Sliding window, remove elements from the tail |
| 1114 | [FirstInOrder](https://leetcode.com/problems/print-in-order/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/1114.print-in-order.cs) | Event-based blocking ManualResetEventSlim |
| 1115 | [PrintFooBarAlternately](https://leetcode.com/problems/print-foobar-alternately/description/) | [C#](https://github.com/NikiforovAll/leetcode-playground/blob/master/src/LeetCodeSolutions/1115.print-foo-bar-alternately.cs) | Event-based blocking ManualResetEventSlim |

## Other Leetcode Repos

1. <https://github.com/tangweikun/awesome-leetcode>
2. [haoel's leetcode](https://github.com/haoel/leetcode)
3. [soulmachine's leetcode](https://github.com/soulmachine/leetcode)
4. [gouthampradhan's leetcode](https://github.com/gouthampradhan/leetcode)
5. [qiyuangong's leetcode](https://github.com/qiyuangong/leetcode)
