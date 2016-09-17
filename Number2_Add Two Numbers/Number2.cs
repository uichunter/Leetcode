using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode
{
    class Number2
    {
        /*You are given two linked lists representing two non-negative numbers.
         * The digits are stored in reverse order and each of their nodes contain a single digit.
         * Add the two numbers and return it as a linked list.

        Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        Output: 7 -> 0 -> 8 */

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            bool isAdd1 = false;
            int temp = 0;
            ListNode firstNode = new ListNode(0);
            ListNode Head = firstNode;

            while (l1.next != null || l2.next != null)
            {
                if (isAdd1)
                {
                    temp = l1.val + l2.val + 1;
                    isAdd1 = false;
                }
                else
                {
                    temp = l1.val + l2.val;
                }

                if (temp >= 10)
                {
                    isAdd1 = true;
                }
                l1 = l1.next;
                l2 = l2.next;
                firstNode.next = new ListNode(temp % 10);
                firstNode = firstNode.next;
            }

            firstNode.next = new ListNode(temp % 10);

            return Head.next;
        }
    }
}
