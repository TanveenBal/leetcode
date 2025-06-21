/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var isIsomorphic = function (s, t) {
  if (s.length !== t.length) return false;

  const mapst = {};
  const mapts = {};
  for (let i = 0; i < t.length; ++i) {
    if (!mapst[s[i]]) mapst[s[i]] = t[i];
    if (!mapts[t[i]]) mapts[t[i]] = s[i];

    if (mapst[s[i]] !== t[i] || mapts[t[i]] !== s[i]) return false;
  }

  return true;
};
