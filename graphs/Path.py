from typing import List

class Node:
    def __init__(self, id: str):
        self.id = id
        self.neighbors: List[Node] = []

    def add_neighbor(self, neighbor: 'Node'):
        self.neighbors.append(neighbor)

def get_path(root: Node, start_id: str, end_id: str) -> List[str]:
    path = []

    def dfs(node: Node, started: bool) -> bool:
        nonlocal path

        if node.id == start_id:
            started = True

        if started:
            path.append(node.id)

        if started and node.id == end_id:
            return True # Finished

        for neighbor in node.neighbors:
            f = dfs(neighbor, started)
            if f:
                return True

        if started and (not path or path[-1] != end_id):
            path.pop()

        return False

    dfs(root, False)
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
