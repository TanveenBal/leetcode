/**
 * @param {string} pattern
 * @param {string} s
 * @return {boolean}
 */
var wordPattern = function (pattern, s) {
  const strings = s.split(" ");
  if (strings.length !== pattern.length) return false;

  const mapps = {};
  const mapsp = {};

  for (let i = 0; i < pattern.length; ++i) {
    if (!mapps[pattern[i]]) mapps[pattern[i]] = strings[i];
    if (!mapsp[strings[i]]) mapsp[strings[i]] = pattern[i];

    if (mapps[pattern[i]] !== strings[i] || mapsp[strings[i]] !== pattern[i])
      return false;
  }

  return true;
};
