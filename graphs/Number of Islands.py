from collections import deque
def numIslands(grid: list[list[str]]) -> int:
    seen = set()
    ans = 0
    rows = len(grid)
    cols = len(grid[0])

    def bfs(origin):
        nonlocal ans
        dirs = [(0, -1), (0, 1), (-1, 0), (1, 0)]
        queue = deque([origin])
        while queue:
            currx, curry = queue.popleft()
            if (currx, curry) in seen:
                continue

            seen.add((currx, curry))
            for dx, dy in dirs:
                newdx, newdy = currx + dx, curry + dy
                if (0 <= newdx < rows and
                    0 <= newdy < cols and
                    grid[newdx][newdy] == '1'):
                    queue.append((newdx, newdy))

    for r in range(rows):
        for c in range(cols):
            if grid[r][c] == '1' and (r, c) not in seen:
                bfs((r, c))
                ans += 1

    return  ans


print(numIslands([["0","1","1","1","0"],["0","1","0","1","0"],["1","1","0","0","0"],["0","0","0","0","0"]]))
print(numIslands([
    ["1","1","0","0","1"],
    ["1","1","0","0","1"],
    ["0","0","1","0","0"],
    ["0","0","0","1","1"]
]))
