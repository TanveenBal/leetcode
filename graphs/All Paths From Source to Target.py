from typing import List
def allPathsSourceTarget(graph: List[List[int]]) -> List[List[int]]:
    n = len(graph) - 1

    paths = []
    def dfs(node, path):
        if node == n:
            paths.append(path)
            return
        for child in graph[node]:
            path.append(child)
            dfs(child, path[:])
            path.pop()

    dfs(0, [0])
    return paths

print(allPathsSourceTarget([[1,2],[3],[3],[]]))
print(allPathsSourceTarget([[4,3,1],[3,2,4],[3],[4],[]]))
