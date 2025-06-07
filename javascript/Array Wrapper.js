/**
 * @param {number[]} nums
 * @return {void}
 */
var ArrayWrapper = function (nums) {
  this.arr = nums;
  this.sum = 0;
  this.arr.forEach((num) => {
    this.sum += num;
  });
};

/**
 * @return {number}
 */
ArrayWrapper.prototype.valueOf = function () {
  return this.sum;
};

/**
 * @return {string}
 */
ArrayWrapper.prototype.toString = function () {
  return JSON.stringify(this.arr);
};

/**
 * const obj1 = new ArrayWrapper([1,2]);
 * const obj2 = new ArrayWrapper([3,4]);
 * obj1 + obj2; // 10
 * String(obj1); // "[1,2]"
 * String(obj2); // "[3,4]"
 */
