/**
 * @param {string} pattern
 * @param {string} s
 * @return {boolean}
 */
var wordPattern = function (pattern, s) {
  const strings = s.split(" ");
  if (strings.length !== pattern.length) return false;

  const ps = new Map();
  const sp = new Map();

  for (let i = 0; i < pattern.length; ++i) {
    const p = pattern[i];
    const word = strings[i];

    if (!ps.has(p)) ps.set(p, word);
    if (!sp.has(word)) sp.set(word, p);

    if (ps.get(p) !== word || sp.get(word) !== p) return false;
  }

  return true;
};
