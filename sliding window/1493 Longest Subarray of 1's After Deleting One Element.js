/**
 * @param {number[]} nums
 * @return {number}
 */
var longestSubarray = function (nums) {
  let zero_ind = 0;
  let deleted = false;
  let ans = 0;
  let l = 0;

  nums.forEach((num, r) => {
    if (num === 0) {
      if (deleted) {
        l = zero_ind + 1;
      } else {
        deleted = true;
      }
      zero_ind = r;
    }
    ans = Math.max(ans, r - l);
  });

  return ans;
};

console.log(longestSubarray([1, 1, 0, 1]));
console.log(longestSubarray([0, 1, 1, 1, 0, 1, 1, 0, 1]));
console.log(longestSubarray([1, 1, 1]));
