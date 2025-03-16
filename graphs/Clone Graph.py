from typing import Optional
from collections import deque

class Node:
    def __init__(self, val = 0, neighbors = None):
        self.val = val
        self.neighbors = neighbors if neighbors is not None else []

def cloneGraph(node: Optional['Node']) -> Optional['Node']:
    if not node:
        return Node()

    old_to_new = {}
    queue = deque([node])
    visited = set()

    while queue:
        curr = queue.popleft()
        if curr in visited:
            continue
        visited.add(curr)

        if curr not in old_to_new:
            old_to_new[curr] = Node(curr.val)

        for n in curr.neighbors:
            if n not in old_to_new:
                old_to_new[n] = Node(n.val)
            old_to_new[curr].neighbors.append(old_to_new[n])
            queue.append(n)

    return old_to_new[node]
