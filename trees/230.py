import heapq
class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

def kthSmallest(root, k: int) -> int:
    if not root:
        return -1
    heap = []
    added = 0
    ans = -1
    def traverse(node):
        nonlocal added
        if added == k:
            nonlocal ans
            ans = -heapq.heappop(heap)
            return
        if not node:
            return
        traverse(node.left)
        added += 1
        heapq.heappush(heap, -node.val)
        traverse(node.right)

    traverse(root)
    return ans
