var TimeLimitedCache = function () {
  this.cache = new Map();
  this.curr_count = 0;
}; /**
 * @param {number} key
 * @param {number} value
 * @param {number} duration time until expiration in ms
 * @return {boolean} if un-expired key already existed
 */
TimeLimitedCache.prototype.set = function (key, value, duration) {
  let exists = false;
  if (this.cache.has(key)) {
    this.curr_count -= 1;
    exists = true;
    clearTimeout(this.cache.get(key).timer);
  }

  this.curr_count += 1;
  this.cache.set(key, {
    value,
    timer: setTimeout(() => {
      this.cache.delete(key);
      this.curr_count -= 1;
    }, duration),
  });

  return exists;
};

/**
 * @param {number} key
 * @return {number} value associated with key
 */
TimeLimitedCache.prototype.get = function (key) {
  if (this.cache.has(key)) {
    return this.cache.get(key).value;
  } else {
    return -1;
  }
};

/**
 * @return {number} count of non-expired keys
 */
TimeLimitedCache.prototype.count = function () {
  return this.curr_count;
};

/**
 * const timeLimitedCache = new TimeLimitedCache()
 * timeLimitedCache.set(1, 42, 1000); // false
 * timeLimitedCache.get(1) // 42
 * timeLimitedCache.count() // 1
 */
