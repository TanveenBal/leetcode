/**
 * @param {number} target
 * @param {number[]} nums
 * @return {number}
 */
var minSubArrayLen = function (target, nums) {
  // add to window if curr < target
  // remove from window if curr > target
  // if curr === target ans = min(ans, curr)
  // keep going
  let l = 0,
    curr = 0,
    ans = nums.length + 1;

  for (let r = 0; r < nums.length; ++r) {
    curr += nums[r];
    while (curr >= target) {
      ans = Math.min(ans, r - l + 1);
      curr -= nums[l];
      ++l;
    }
  }

  return ans !== nums.length + 1 ? ans : 0;
};
