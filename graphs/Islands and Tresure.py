from collections import deque

def islandsAndTreasure(grid: list[list[int]]) -> None:
    INF = 2147483647
    rows = len(grid)
    cols = len(grid[0])
    dirs = [(-1, 0), (0, -1), (1, 0), (0, 1)]

    def bfs(r, c):
        dist = 0
        queue = deque([(r, c)])
        visited = set([(r, c)])

        while queue:
            dist += 1
            for _ in range(len(queue)):
                cx, cy = queue.popleft()
                for dx, dy in dirs:
                    newx, newy = cx + dx, cy + dy
                    if (0 <= newx < rows and
                        0 <= newy < cols and
                        (newx, newy) not in visited and
                        grid[newx][newy] != -1):
                        if grid[newx][newy] == 0:
                            grid[r][c] = dist
                            return
                        visited.add((newx, newy))
                        queue.append((newx, newy))

    for r in range(rows):
        for c in range(cols):
            if grid[r][c] == INF:
                bfs(r, c)

    print(grid)

islandsAndTreasure([
  [2147483647,-1,0,2147483647],
  [2147483647,2147483647,2147483647,-1],
  [2147483647,-1,2147483647,-1],
  [0,-1,2147483647,2147483647]
])

islandsAndTreasure([
  [0,-1],
  [2147483647,2147483647]
])
