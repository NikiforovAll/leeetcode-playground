/*
 * @lc app=leetcode id=1115 lang=csharp
 *
 * [1115] Print FooBar Alternately
 *
 * https://leetcode.com/problems/print-foobar-alternately/description/
 *
 * concurrency
 * Medium (57.94%)
 * Likes:    244
 * Dislikes: 22
 * Total Accepted:    22.7K
 * Total Submissions: 39.2K
 * Testcase Example:  '1'
 *
 * Suppose you are given the following code:
 *
 *
 * class FooBar {
 * ⁠ public void foo() {
 * for (int i = 0; i < n; i++) {
 * print("foo");
 * }
 * ⁠ }
 *
 * ⁠ public void bar() {
 * for (int i = 0; i < n; i++) {
 * print("bar");
 * }
 * ⁠ }
 * }
 *
 *
 * The same instance of FooBar will be passed to two different threads. Thread
 * A will call foo() while thread B will call bar(). Modify the given program
 * to output "foobar" n times.
 *
 *
 *
 * Example 1:
 *
 *
 * Input: n = 1
 * Output: "foobar"
 * Explanation: There are two threads being fired asynchronously. One of them
 * calls foo(), while the other calls bar(). "foobar" is being output 1 time.
 *
 *
 * Example 2:
 *
 *
 * Input: n = 2
 * Output: "foobarfoobar"
 * Explanation: "foobar" is being output 2 times.
 *
 *
 */

using System;
// @lc code=start
using System.Threading;
public class FooBar {
    private int n;

    readonly ManualResetEventSlim mres1 = new ManualResetEventSlim(true);
    readonly ManualResetEventSlim mres2 = new ManualResetEventSlim(false);
    public FooBar(int n) {
        this.n = n;
    }

    public void Foo(Action printFoo) {

        for (int i = 0; i < n; i++) {
            mres1.Wait();
        	// printFoo() outputs "foo". Do not change or remove this line.
        	printFoo();
            mres1.Reset();
            mres2.Set();
        }
        mres1.Dispose();
    }

    public void Bar(Action printBar) {

        for (int i = 0; i < n; i++) {
            mres2.Wait();
            // printBar() outputs "bar". Do not change or remove this line.
        	printBar();
            mres2.Reset();
            mres1.Set();
        }
        mres2.Dispose();
    }
}
// @lc code=end

