/**
 * @param {Array} arr1
 * @param {Array} arr2
 * @return {Array}
 */
var join = function (arr1, arr2) {
  const ans = {};

  arr1.forEach((element) => (ans[element.id] = { ...element }));

  arr2.forEach((element) => {
    if (ans[element.id]) {
      ans[element.id] = { ...ans[element.id], ...element };
    } else {
      ans[element.id] = { ...element };
    }
  });

  return Object.values(ans);
};
