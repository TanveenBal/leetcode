from typing import List, Optional

class Node:
    def __init__(self, id: str):
        self.id = id
        self.neighbors: List[Node] = []

    def add_neighbor(self, neighbor: 'Node'):
        self.neighbors.append(neighbor)

def get_path(root: Node, start_id: str, end_id: str) -> List[str]:
    path = []
    start = False
    finished = False
    def dfs(node: Node):
        nonlocal finished, start, path
        if node.id == end_id and start:
            path.append(node.id)
            finished = True
            return
        if node.id == start_id:
            start = True

        for neighbor in node.neighbors:
            if start:
                path.append(node.id)
            dfs(neighbor)
            if finished:
                return
            if start and path:
                path.pop()

        if start:
            start = False

    dfs(root)
    return path

a = Node("A")
b = Node("B")
c = Node("C")
d = Node("D")
e = Node("E")

a.add_neighbor(b)
a.add_neighbor(c)
b.add_neighbor(d)
c.add_neighbor(e)
d.add_neighbor(e)

path = get_path(a, "B", "E")
print("Path from B to E:", path)

n1 = Node("1")
n2 = Node("2")
n3 = Node("3")
n4 = Node("4")
n5 = Node("5")
n6 = Node("6")
n7 = Node("7")
n8 = Node("8")

n1.add_neighbor(n2)
n1.add_neighbor(n4)
n1.add_neighbor(n3)
n2.add_neighbor(n5)
n2.add_neighbor(n7)
n3.add_neighbor(n6)
n5.add_neighbor(n8)

path = get_path(n1, "1", "8")
print("Path from 1 to 8:", path)

path2 = get_path(n1, "3", "8")
print("Path from 3 to 8:", path2)
