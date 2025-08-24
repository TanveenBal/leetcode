/**
 * @param {number[]} nums
 */
var NumArray = function (nums) {
  this.nums = nums;
  this.prefix = Array(nums.length);
  this.prefix[0] = this.nums[0];
  for (let i = 1; i < nums.length; ++i) {
    this.prefix[i] = this.prefix[i - 1] + nums[i];
  }
};

/**
 * @param {number} index
 * @param {number} val
 * @return {void}
 */
NumArray.prototype.update = function (index, val) {
  this.nums[index] = val;
  this.prefix[index] = index === 0 ? val : this.prefix[index - 1] + val;
  for (let i = index + 1; i < this.nums.length; ++i) {
    this.prefix[i] = this.prefix[i - 1] + this.nums[i];
  }
};

/**
 * @param {number} left
 * @param {number} right
 * @return {number}
 */
NumArray.prototype.sumRange = function (left, right) {
  if (left === 0) return this.prefix[right];
  return this.prefix[right] - this.prefix[left - 1];
};

/**
 * Your NumArray object will be instantiated and called as such:
 * var obj = new NumArray(nums)
 * obj.update(index,val)
 * var param_2 = obj.sumRange(left,right)
 */
