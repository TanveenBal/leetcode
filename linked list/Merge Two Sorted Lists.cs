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
public class SolutionMergeTwoLists
{
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        ListNode? merged = new ListNode();
        ListNode? currm = merged;


        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                currm.next = list1;
                list1 = list1.next;
            }
            else
            {
                currm.next = list2;
                list2 = list2.next;
            }

            currm = currm.next;
        }

        if (list1 != null)
            currm.next = list1;

        if (list2 != null)
            currm.next = list2;

        return merged.next;
    }
}
