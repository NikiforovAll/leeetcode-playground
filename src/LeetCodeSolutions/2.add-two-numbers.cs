/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 *
 * https://leetcode.com/problems/add-two-numbers/description/
 *
 * algorithms
 * Medium (33.36%)
 * Likes:    7950
 * Dislikes: 2031
 * Total Accepted:    1.4M
 * Total Submissions: 4.1M
 * Testcase Example:  '[2,4,3]\n[5,6,4]'
 *
 * You are given two non-empty linked lists representing two non-negative
 * integers. The digits are stored in reverse order and each of their nodes
 * contain a single digit. Add the two numbers and return it as a linked list.
 *
 * You may assume the two numbers do not contain any leading zero, except the
 * number 0 itself.
 *
 * Example:
 *
 *
 * Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
 * Output: 7 -> 0 -> 8
 * Explanation: 342 + 465 = 807.
 *
 *
 */
namespace _2
{
    // @lc code=start
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int val=0, ListNode next=null) {
     *         this.val = val;
     *         this.next = next;
     *     }
     * }
     */
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var prev = 0;
            ListNode prevNode = null;
            var root = new ListNode();
            var curr = root;
            while (l1 != null || l2 != null || prev != 0)
            {
                var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + prev;
                curr.val = sum % 10;
                prev = sum / 10;
                if (prevNode != null)
                    prevNode.next = curr;
                prevNode = curr;
                l1 = l1?.next;
                l2 = l2?.next;
                curr = new ListNode();
            }
            return root;
            // it is also possible to initialize dummyHead and than return dummyHead.next
        }
    }
    // @lc code=end
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
