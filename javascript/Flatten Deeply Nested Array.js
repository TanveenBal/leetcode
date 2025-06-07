/**
 * @param {Array} arr
 * @param {number} depth
 * @return {Array}
 */
var flat = function (arr, n) {
  if (!n) return arr;

  const flatten = function (array, depth) {
    if (depth === 0) return array;
    const newArr = [];

    for (let i = 0; i < array.length; ++i) {
      if (Array.isArray(array[i])) {
        newArr.push(...flatten(array[i], depth - 1));
      } else {
        newArr.push(array[i]);
      }
    }
    return newArr;
  };

  return flatten(arr, n);
};
