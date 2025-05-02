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
public class SolutionRemoveNthFromEnd
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode left = head;
        ListNode right = head;

        for (int i = 0; i < n; ++i, right = right.next) { }

        if (right == null)
            return head.next;

        while (right.next != null)
        {
            right = right.next;
            left = left.next;
        }

        left.next = left.next.next;

        return head;
    }
    /*NOTE: Easy iterative two pass solution*/

    /*public ListNode RemoveNthFromEnd(ListNode head, int n)*/
    /*{*/
    /*    int len = 0;*/
    /*    ListNode curr = head;*/
    /**/
    /*    for (; curr != null; curr = curr.next)*/
    /*        ++len;*/
    /**/
    /*    curr = head;*/
    /*    int rem = len - n - 1;*/
    /*    if (rem == -1)*/
    /*        return head.next;*/
    /**/
    /*    for (int i = 0; i < rem; ++i)*/
    /*        curr = curr.next;*/
    /**/
    /*    if (curr.next != null)*/
    /*        curr.next = curr.next.next;*/
    /*    return head;*/
    /*}*/
}
