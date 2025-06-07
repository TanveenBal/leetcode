/**
 * @param {Object|Array} obj
 * @return {Object|Array}
 */

var compactObject = function (obj) {
  if (obj === null) return null;

  if (Array.isArray(obj)) {
    const result = [];

    for (let i = 0; i < obj.length; i++) {
      const val = obj[i];
      if (!val) continue;
      result.push(compactObject(val));
    }

    return result;
  }

  if (typeof obj !== "object") return obj;

  const compacted = {};
  for (const key in obj) {
    const value = compactObject(obj[key]);
    if (value) compacted[key] = value;
  }

  return compacted;
};
