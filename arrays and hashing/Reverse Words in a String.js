/**
 * @param {string} s
 * @return {string}
 */
var reverseWords = function (s) {
  let words = [];
  let curWord = "";
  for (const c of s) {
    if (c === " " && curWord !== "") {
      words.push(curWord);
      curWord = "";
    }
    if (c !== " ") {
      curWord += c;
    }
  }
  if (curWord !== "") {
    words.push(curWord);
  }

  let result = "";
  for (let i = words.length; i >= 0; --i) {
    if (words[i]) result += words[i] + " ";
  }
  return result.trim();
};
