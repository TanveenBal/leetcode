from typing import List
from collections import deque

def pacificAtlantic(heights: List[List[int]]) -> List[List[int]]:
    rows = len(heights)
    cols = len(heights[0])
    dirs = [(0, 1), (0, -1), (-1, 0), (1, 0)]

    def bfs(r, c):
        queue = deque([(r, c)])
        visited = set([(r, c)])

        while queue:
            cr, cc = queue.popleft()

            for dr, dc in dirs:
                newr, newc = cr + dr, cc + dc
                if (0 <= newr < rows and
                    0 <= newc < cols and
                    (newr, newc) not in visited and
                    heights[cr][cc] <= heights[newr][newc]):
                    visited.add((newr, newc))
                    queue.append((newr, newc))

        return visited


    pacific = set()
    atlantic = set()

    for r in range(rows):
        pacific.update(bfs(r, 0))
        atlantic.update(bfs(r, cols - 1))

    for c in range(cols):
        pacific.update(bfs(0, c))
        atlantic.update(bfs(rows - 1, c))


    return list(pacific.intersection(atlantic))

# def pacificAtlantic(self, heights: List[List[int]]) -> List[List[int]]:
#     rows = len(heights)
#     cols = len(heights[0])
#     dirs = [(0, 1), (0, -1), (-1, 0), (1, 0)]
#
#     def bfs(r, c):
#         queue = deque([(r, c)])
#         visited = set()
#         pacific = False
#         atlantic = False
#
#         while queue:
#             cr, cc = queue.popleft()
#             visited.add((cr, cc))
#
#             for dr, dc in dirs:
#                 newr, newc = cr + dr, cc + dc
#                 if (0 <= newr < rows and
#                     0 <= newc < cols):
#                     if ((newr, newc) not in visited and
#                         heights[cr][cc] >= heights[newr][newc]):
#                         queue.append((newr, newc))f
#                 else:
#                     if newr >= rows or newc >= cols:
#                         atlantic = True
#                     if newr < 0 or newc < 0:
#                         pacific = True
#
#         return pacific and atlantic
#
#     ans = []
#     for r in range(rows):
#         for c in range(cols):
#             if bfs(r, c):
#                 ans.append([r, c])
#
#     return ans

print(pacificAtlantic([[1,2,2,3,5],[3,2,3,4,4],[2,4,5,3,1],[6,7,1,4,5],[5,1,1,2,4]]))
