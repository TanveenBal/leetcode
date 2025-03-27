from typing import List


def riverSizes(grid: List[List[int]]) -> List[int]:
    rows, cols = len(grid), len(grid[0])

    sizes = []
    seen = set()
    dirs = [(1, 0), (0, 1), (-1, 0), (0, -1)]

    def dfs(r, c):
        if (
            r < 0
            or r >= rows
            or c < 0
            or c >= cols
            or (r, c) in seen
            or grid[r][c] != 1
        ):
            return 0

        seen.add((r, c))
        sizes[-1] += 1
        for dr, dc in dirs:
            dfs(dr + r, dc + c)

    for r in range(rows):
        for c in range(cols):
            if (r, c) not in seen and grid[r][c] == 1:
                sizes.append(0)
                dfs(r, c)

    return sizes


print(riverSizes([[0, 0, 0, 1], [1, 1, 0, 0], [1, 0, 0, 1], [1, 0, 0, 1]]))
print(riverSizes([[0, 0, 0, 1, 1], [1, 1, 0, 0, 1], [0, 0, 0, 1, 1], [0, 0, 0, 1, 0]]))
