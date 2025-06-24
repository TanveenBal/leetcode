/**
 * @param {number[][]} matrix
 */
var NumMatrix = function (matrix) {
  if (!matrix || matrix.length === 0 || matrix[0].length === 0) {
    this.prefixSum = [[]];
    return;
  }
  const m = matrix.length;
  const n = matrix[0].length;
  this.prefixSum = Array.from({ length: m + 1 }, () => Array(n + 1).fill(0));

  for (let i = 0; i < m; i++) {
    for (let j = 0; j < n; j++) {
      this.prefixSum[i + 1][j + 1] =
        this.prefixSum[i][j + 1] +
        this.prefixSum[i + 1][j] -
        this.prefixSum[i][j] +
        matrix[i][j];
    }
  }
};

/**
 * @param {number} row1
 * @param {number} col1
 * @param {number} row2
 * @param {number} col2
 * @return {number}
 */
NumMatrix.prototype.sumRegion = function (row1, col1, row2, col2) {
  return (
    this.prefixSum[row2 + 1][col2 + 1] -
    this.prefixSum[row2 + 1][col1] -
    this.prefixSum[row1][col2 + 1] +
    this.prefixSum[row1][col1]
  );
};

/**
 * Your NumMatrix object will be instantiated and called as such:
 * var obj = new NumMatrix(matrix)
 * var param_1 = obj.sumRegion(row1,col1,row2,col2)
 */
