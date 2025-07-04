/**
 * @param {number[]} nums
 * @param {number} k
 * @return {void} Do not return anything, modify nums in-place instead.
 */
// var rotate = function (nums, k) {
//   let count = 0;
//   for (let start = 0; count < nums.length; start++) {
//     let current = start;
//     let prev = nums[start];
//
//     do {
//       let next = (current + k) % nums.length;
//       let temp = nums[next];
//       nums[next] = prev;
//       prev = temp;
//       current = next;
//       count++;
//     } while (current !== start);
//   }
// };

var reverse = function (left, right, arr) {
  while (left <= right) {
    let temp = arr[left];
    arr[left] = arr[right];
    arr[right] = temp;
    ++left;
    --right;
  }
};

var rotate = function (nums, k) {
  k = k % nums.length;
  reverse(0, nums.length - 1, nums);
  reverse(0, k - 1, nums);
  reverse(k, nums.length - 1, nums);
};
