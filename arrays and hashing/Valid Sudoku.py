def isValidSudoku(board: list[list[str]]) -> bool:
    threebythree = [set() for _ in range(9)]
    rows = [set() for _ in range(9)]
    cols = [set() for _ in range(9)]

    r_l = len(board)
    c_l = len(board[0])

    for r in range(r_l):
        for c in range(c_l):
            threebythree_i = (r // 3) * 3 + (c // 3)
            tile = board[r][c]
            if tile != '.':
                if tile in rows[r] or tile in cols[c] or tile in threebythree[threebythree_i]:
                    return False
                else:
                    rows[r].add(tile)
                    cols[c].add(tile)
                    threebythree[threebythree_i].add(tile)

    return True


print(isValidSudoku([["1","2",".",".","3",".",".",".","."],
 ["4",".",".","5",".",".",".",".","."],
 [".","9","8",".",".",".",".",".","3"],
 ["5",".",".",".","6",".",".",".","4"],
 [".",".",".","8",".","3",".",".","5"],
 ["7",".",".",".","2",".",".",".","6"],
 [".",".",".",".",".",".","2",".","."],
 [".",".",".","4","1","9",".",".","8"],
 [".",".",".",".","8",".",".","7","9"]]))
