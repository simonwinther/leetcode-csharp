using System;
namespace leetcode_csharp.problems
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

    public class MergeTwoLinkedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode root = new ListNode();
            ListNode prev = root;

            while(list1 != null && list2 != null)
            {
                if(list1.val < list2.val)
                {
                    prev.next = list1;
                    list1 = list1.next;
                } else
                {
                    prev.next = list2;
                    list2 = list2.next;
                }
                prev = prev.next;
            }

            prev.next = list1 != null ? list1 : list2;
            return root.next;
        }
    }
}

