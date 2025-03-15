def maxAreaOfIsland(grid: list[list[int]]) -> int:
    ans = 0
    visited = set()
    rows = len(grid)
    cols = len(grid[0])

    def dfs(x, y):
        if ((x, y) in visited or
            x < 0 or x >= rows or
            y < 0 or y >= cols or
            grid[x][y] == 0):
            return 0

        visited.add((x, y))
        return (1 + dfs(x, y + 1)
            + dfs(x, y - 1)
            + dfs(x + 1, y)
            + dfs(x - 1, y))

    for r in range(rows):
        for c in range(cols):
            if grid[r][c] == 1 and (r, c) not in visited:
                ans = max(ans, dfs(r, c))


    return ans

print(maxAreaOfIsland([[0,0,1,0,0,0,0,1,0,0,0,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,1,1,0,1,0,0,0,0,0,0,0,0],[0,1,0,0,1,1,0,0,1,0,1,0,0],[0,1,0,0,1,1,0,0,1,1,1,0,0],[0,0,0,0,0,0,0,0,0,0,1,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,0,0,0,0,0,0,1,1,0,0,0,0]]))
print(maxAreaOfIsland([[0,0,0,0,0,0,0,0]]))
