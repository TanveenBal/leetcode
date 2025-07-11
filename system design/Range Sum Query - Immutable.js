/**
 * @param {number[]} nums
 */
var NumArray = function (nums) {
  this.prefix = nums;

  for (let i = 1; i < nums.length; ++i) {
    this.prefix[i] += this.prefix[i - 1];
  }
};

/**
 * @param {number} left
 * @param {number} right
 * @return {number}
 */
NumArray.prototype.sumRange = function (left, right) {
  if (left == 0) return this.prefix[right];
  return this.prefix[right] - this.prefix[left - 1];
};

/**
 * Your NumArray object will be instantiated and called as such:
 * var obj = new NumArray(nums)
 * var param_1 = obj.sumRange(left,right)
 */
