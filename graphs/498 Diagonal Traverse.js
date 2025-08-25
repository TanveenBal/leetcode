/**
 * @param {number} row
 * @param {number} col
 * @param {number} rowLen
 * @param {number} colLen
 * @param {number} dirRow
 * @param {number} dirCol
 * @return {number[]}
 */
var nextStart = function (row, col, rowLen, colLen, dirRow, dirCol) {
  const up = isUp(dirRow, dirCol);
  let ans = [];
  if (up) {
    if (col + 1 < colLen) {
      ans.push(row);
      ans.push(col + 1);
    } else {
      ans.push(row + 1);
      ans.push(col);
    }
  } else {
    if (row + 1 < rowLen) {
      ans.push(row + 1);
      ans.push(col);
    } else {
      ans.push(row);
      ans.push(col + 1);
    }
  }
  ans.push(dirRow * -1);
  ans.push(dirCol * -1);
  return ans;
};

/**
 * @param {number} dirRow
 * @param {number} dirCol
 * @return {boolean}
 */
var isUp = function (dirRow, dirCol) {
  return dirRow === -1 && dirCol === 1;
};

/**
 * @param {number} row
 * @param {number} col
 * @param {number} rowLen
 * @param {number} colLen
 * @return {boolean}
 */
var inBounds = function (row, col, rowLen, colLen) {
  return row >= 0 && row < rowLen && col >= 0 && col < colLen;
};

/**
 * @param {number[][]} mat
 * @return {number[]}
 */
var findDiagonalOrder = function (mat) {
  if (mat.length === 1) return [...mat[0]];
  let ans = [],
    dirRow = -1,
    dirCol = 1,
    rowLen = mat.length,
    colLen = mat[0].length,
    r = 0,
    c = 0;

  while (inBounds(r, c, rowLen, colLen)) {
    while (inBounds(r, c, rowLen, colLen)) {
      ans.push(mat[r][c]);
      r += dirRow;
      c += dirCol;
    }
    [r, c, dirRow, dirCol] = nextStart(
      r - dirRow,
      c - dirCol,
      rowLen,
      colLen,
      dirRow,
      dirCol,
    );
  }
  return ans;
};

console.log(
  findDiagonalOrder([
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9],
  ]),
);

console.log(findDiagonalOrder([[2, 3]]));
