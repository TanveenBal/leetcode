/**
 * @param {character[][]} board
 * @return {boolean}
 */
var isValidSudoku = function (board) {
  const rows = board[0].length,
    cols = board.length,
    horizontal = Array.from({ length: rows }, () => new Set()),
    vertical = Array.from({ length: cols }, () => new Set()),
    square = Array.from({ length: 3 }, () =>
      Array.from({ length: 3 }, () => new Set()),
    );

  for (let r = 0; r < rows; ++r) {
    for (let c = 0; c < cols; ++c) {
      let curr = board[r][c];
      if (curr === ".") continue;
      let squareRow = Math.floor(r / 3),
        squareCol = Math.floor(c / 3);

      if (
        horizontal[r].has(curr) ||
        vertical[c].has(curr) ||
        square[squareRow][squareCol].has(curr)
      ) {
        return false;
      }
      horizontal[r].add(curr);
      vertical[c].add(curr);
      square[squareRow][squareCol].add(curr);
    }
  }

  return true;
};

console.log(
  isValidSudoku([
    ["5", "3", ".", ".", "7", ".", ".", ".", "."],
    ["6", ".", ".", "1", "9", "5", ".", ".", "."],
    [".", "9", "8", ".", ".", ".", ".", "6", "."],
    ["8", ".", ".", ".", "6", ".", ".", ".", "3"],
    ["4", ".", ".", "8", ".", "3", ".", ".", "1"],
    ["7", ".", ".", ".", "2", ".", ".", ".", "6"],
    [".", "6", ".", ".", ".", ".", "2", "8", "."],
    [".", ".", ".", "4", "1", "9", ".", ".", "5"],
    [".", ".", ".", ".", "8", ".", ".", "7", "9"],
  ]),
);
