/**
 * @param {number[]} nums
 * @return {number}
 */
var minimumOperations = function (nums) {
  let ans = 0;
  nums.forEach((num) => {
    if (num % 3) ans += 1;
  });
  return ans;
};
