/**
 * @param {Array<Function>} functions
 * @return {Promise<any>}
 */
var promiseAll = function (functions) {
  return new Promise((resolve, reject) => {
    const ans = [];
    let finished = 0;
    functions.forEach((fn, i) => {
      fn()
        .then((res) => {
          ans[i] = res;
          ++finished;
          if (finished === functions.length) resolve(ans);
        })
        .catch((rej) => reject(rej));
    });
  });
};

/**
 * Example usage:
 * const promise = promiseAll([() => new Promise(res => res(42))]);
 * promise.then(console.log); // [42]
 */
