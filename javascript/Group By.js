/**
 * @param {Function} fn
 * @return {Object}
 */
Array.prototype.groupBy = function (fn) {
  const map = new Map();
  for (let i = 0; i < this.length; ++i) {
    let key = fn(this[i]);
    if (map.has(key)) map.get(key).push(this[i]);
    else {
      let value = [];
      value.push(this[i]);
      map.set(key, value);
    }
  }

  return Object.fromEntries(map);
};

/**
 * [1,2,3].groupBy(String) // {"1":[1],"2":[2],"3":[3]}
 */
