/**
 * @param {string} pattern
 * @param {string} s
 * @return {boolean}
 */
var wordPattern = function (pattern, s) {
  const strings = s.split(" ");
  if (strings.length !== pattern.length) return false;

  const mapps = new Map();
  const mapsp = new Map();

  for (let i = 0; i < pattern.length; ++i) {
    const p = pattern[i];
    const word = strings[i];

    if (!mapps.has(p)) mapps.set(p, word);
    if (!mapsp.has(word)) mapsp.set(word, p);

    if (mapps.get(p) !== word || mapsp.get(word) !== p) return false;
  }

  return true;
};
