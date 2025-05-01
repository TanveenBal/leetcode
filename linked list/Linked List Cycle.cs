/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class SolutionHasCycle
{
    public bool HasCycle(ListNode head)
    {
        if (head == null || head.next == null || head.next.next == null)
            return false;

        ListNode slow = head;
        ListNode fast = head.next.next;

        while (fast != null && fast.next != null && fast.next.next != null)
        {
            if (slow == fast)
                return true;
            slow = slow.next;
            fast = fast.next;
        }

        return false;
    }
}
