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
public class SolutionMergeKLists
{
    private ListNode Merge(ListNode m1, ListNode m2)
    {
        ListNode merged = new ListNode(0);
        ListNode curr = merged;
        while (m1 != null && m2 != null)
        {
            if (m1.val <= m2.val)
            {
                curr.next = m1;
                m1 = m1.next;
            }
            else
            {
                curr.next = m2;
                m2 = m2.next;
            }
            curr = curr.next;
        }

        if (m1 != null)
            curr.next = m1;
        else
            curr.next = m2;

        return merged.next;
    }
    public ListNode MergeKLists(ListNode[] lists)
    {
        int k = lists.Length;
        if (k == 0)
            return null;

        for (int i = 1; i < lists.Length; ++i)
        {
            ListNode merged = Merge(lists[0], lists[i]);
            lists[0] = merged;
        }

        return lists[0];
    }
}
