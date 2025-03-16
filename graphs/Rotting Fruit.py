from collections import deque

def orangesRotting(grid: list[list[int]]) -> int:
    rows, cols = len(grid), len(grid[0])
    queue = deque()
    fresh_oranges = 0

    for r in range(rows):
        for c in range(cols):
            if grid[r][c] == 2:
                queue.append((r, c))
            elif grid[r][c] == 1:
                fresh_oranges += 1

    directions = [(0, 1), (1, 0), (0, -1), (-1, 0)]
    time = 0
    while queue and fresh_oranges > 0:
        for _ in range(len(queue)):
            x, y = queue.popleft()
            for dx, dy in directions:
                nx, ny = x + dx, y + dy
                if (0 <= nx < rows and
                    0 <= ny < cols and
                    grid[nx][ny] == 1):
                    grid[nx][ny] = 2
                    fresh_oranges -= 1
                    queue.append((nx, ny))
        time += 1

    return time if fresh_oranges == 0 else -1

print(orangesRotting([[1,1,0],[0,1,1],[0,1,2]]))
print(orangesRotting([[1,0,1],[0,2,0],[1,0,1]]))
