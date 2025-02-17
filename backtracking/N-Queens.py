def solveNQueens(n: int) -> list[str]:
    board = [['.' for _ in range(n)] for _ in range(n)]
    ans = []

    def is_safe(row, col):
        for r in range(row):
            if board[r][col] == 'Q':
                return False

        r, c = row, col
        while r >= 0 and c >= 0:
            if board[r][c] == 'Q':
                return False
            r -= 1
            c -= 1

        r, c = row, col
        while r >= 0 and c < n:
            if board[r][c] == 'Q':
                return False
            r -= 1
            c += 1

        return True

    def backtrack(row):
        if row == n:
            ans.append(["".join(r) for r in board])
            return

        for col in range(n):
            if is_safe(row, col):
                board[row][col] = 'Q'
                backtrack(row + 1)
                board[row][col] = '.'

    backtrack(0)
    return ans

print(solveNQueens(4))

