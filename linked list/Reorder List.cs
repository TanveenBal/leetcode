public class SolutionReorderList
{

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

    public void ReorderList(ListNode head)
    {
        ListNode slow = head, fast = head.next;

        // Find middle of the list
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // Reverse second half
        ListNode curr = slow.next;
        ListNode prev = slow.next = null;

        while (curr != null)
        {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }

        ListNode rev = prev; // Head of reversed second half

        // Merge the two lists
        ListNode currH = head;
        ListNode currR = rev;

        while (currR != null)
        {
            ListNode temp1 = currH.next;
            ListNode temp2 = currR.next;

            currH.next = currR;
            currR.next = temp1;

            currH = temp1;
            currR = temp2;
        }
    }
}
