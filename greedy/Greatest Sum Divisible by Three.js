var maxSumDivThree = function (nums) {
  let total = 0;
  let r1 = [];
  let r2 = [];

  for (let n of nums) {
    total += n;
    if (n % 3 === 1) r1.push(n);
    else if (n % 3 === 2) r2.push(n);
  }

  r1.sort((a, b) => a - b);
  r2.sort((a, b) => a - b);

  let rem = total % 3;
  if (rem === 0) return total;

  let remove = Infinity;

  if (rem === 1) {
    if (r1.length > 0) remove = Math.min(remove, r1[0]);
    if (r2.length > 1) remove = Math.min(remove, r2[0] + r2[1]);
  } else {
    if (r2.length > 0) remove = Math.min(remove, r2[0]);
    if (r1.length > 1) remove = Math.min(remove, r1[0] + r1[1]);
  }

  return total - remove;
};
