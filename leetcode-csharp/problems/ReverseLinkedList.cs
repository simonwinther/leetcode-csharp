using System;

namespace leetcode_csharp.problems
{
    public class ReverseLinkedList
    {
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

        public ListNode ReverseList(ListNode head)
        {
            ListNode p = null;
            ListNode q = null;
            ListNode r = head;

            while (r != null)
            {
                p = q;
                q = r;
                r = r.next;
                q.next = p;
            }

            return q;
        }
    }
}

