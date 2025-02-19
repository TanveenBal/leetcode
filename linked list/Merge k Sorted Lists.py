from pydantic import Optional

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


def merge(left: Optional[ListNode], right: Optional[ListNode]) -> Optional[ListNode]:
    merged = ListNode()
    curr = merged
    while left and right:
        if left.val < right.val:
            curr.next = left
            left = left.next
        else:
            curr.next = right
            right = right.next
        curr = curr.next

    if left:
        curr.next = left
    if right:
        curr.next = right

    return merged.next


def mergeKLists(lists: list[Optional[ListNode]]) -> Optional[ListNode]:
    if not lists:
        return None
    if len(lists) == 1:
        return lists[0]

    mid = len(lists) // 2
    left = mergeKLists(lists[:mid])
    right = mergeKLists(lists[mid:])

    return merge(left, right)
