/**
 * @param {Array} arr
 * @param {number} size
 * @return {Array}
 */
var chunk = function (arr, size) {
  let ans = [];
  for (let i = 0; i < arr.length; ) {
    let curr = [];
    let diff = i + size;
    for (; i < arr.length && i < diff; ++i) {
      curr.push(arr[i]);
    }
    ans.push(curr);
  }
  return ans;
};
