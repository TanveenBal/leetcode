/**
 * @param {number[]} nums
 * @return {number}
 */
var removeDuplicates = function (nums) {
  let numCount = 0;
  let currNum = nums[0];
  let move = 0;
  for (const num of nums) {
    if (currNum != num) {
      numCount = 0;
    }

    nums[move] = num;
    if (numCount < 2) ++move;
    ++numCount;
    currNum = num;
  }

  nums.splice(move);
};
