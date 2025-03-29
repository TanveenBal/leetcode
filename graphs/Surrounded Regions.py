from collections import deque
from typing import List

def solve(board: List[List[str]]) -> None:
    seen = set()
    rows, cols = len(board), len(board[0])
    dirs = [(1, 0), (0, 1), (-1, 0), (0, -1)]

    def bfs(x, y):
        queue = deque([(x, y)])

        while queue:
            cx, cy = queue.popleft()
            if (
                cx < 0
                or cx >= rows
                or cy < 0
                or cy >= cols
                or (cx, cy) in seen
                or board[cx][cy] == "X"
            ):
                continue
            board[cx][cy] = "S"
            seen.add((cx, cy))
            for dx, dy in dirs:
                queue.append((cx + dx, cy + dy))

    for r in range(rows):
        if board[r][cols - 1] == "O":
            bfs(r, cols - 1)
        if board[r][0] == "O":
            bfs(r, 0)
    for c in range(cols):
        if board[rows - 1][c] == "O":
            bfs(rows - 1, c)
        if board[0][c] == "O":
            bfs(0, c)

    for r in range(rows):
        for c in range(cols):
            if board[r][c] == "S":
                board[r][c] = "O"
            elif board[r][c] == "O":
                board[r][c] = "X"

    print(board)


# def solve(board: List[List[str]]) -> None:
#     seen = set()
#     rows, cols = len(board), len(board[0])
#     dirs = [(1, 0), (0, 1), (-1, 0), (0, -1)]
#     def bfs(x, y):
#         queue = deque([(x, y)])
#         region = set()
#         surrounded = True
#
#         while queue:
#             cx, cy = queue.popleft()
#             if (0 <= cx < rows and
#                 0 <= cy < cols and
#                 (cx, cy) not in seen and
#                 board[cx][cy] == 'O'):
#                 region.add((cx, cy))
#                 seen.add((cx, cy))
#                 if (cx == 0 or cx == rows - 1 or
#                         cy == 0 or cy == cols - 1):
#                     surrounded = False
#
#                 for dx, dy in dirs:
#                     queue.append((cx + dx, cy + dy))
#
#         if surrounded:
#             for r, c in list(region):
#                 board[r][c] = 'X'
#
#     for r in range(rows):
#         for c in range(cols):
#             if board[r][c] == 'O' and (r, c) not in seen:
#                 bfs(r, c)
#
#     print(board)

solve(
    [
        ["X", "X", "X", "X"],
        ["X", "O", "O", "X"],
        ["X", "O", "O", "X"],
        ["X", "X", "X", "O"],
    ]
)
