/*Definition for singly-linked list.*/
public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int x) { val = x; }
}

public class SolutionGetIntersectionNode
{
    public ListNode? GetIntersectionNode(ListNode headA, ListNode headB)
    {
        HashSet<ListNode> setA = new HashSet<ListNode>();

        ListNode? curr = headA;
        while (curr != null)
        {
            setA.Add(curr);
            curr = curr.next;
        }

        curr = headB;
        while (curr != null)
        {
            if (setA.Contains(curr))
                return curr;
            curr = curr.next;
        }
        return null;
    }
}
