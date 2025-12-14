const APPROVED_BUSINESSES = [
  "electronics",
  "grocery",
  "pharmacy",
  "restaurant",
];

/**
 * @param {string} code
 * @param {string} businessLine
 * @param {boolean} active
 * @returns {boolean}
 */
function isValidCoupon(code, businessLine, active) {
  if (!active) return false;
  if (!APPROVED_BUSINESSES.includes(businessLine)) return false;
  if (!code || !/^[A-Za-z0-9_]+$/.test(code)) return false;
  return true;
}

/**
 * @param {string[]} codes
 * @param {string[]} businessLines
 * @param {boolean[]} isActive
 * @returns {string[]}
 */
function validateCoupons(codes, businessLines, isActive) {
  let validCoupons = {};
  codes.forEach((_, index) => {
    const code = codes[index];
    const businessLine = businessLines[index];
    if (isValidCoupon(code, businessLine, isActive[index])) {
      if (!(businessLine in validCoupons)) {
        validCoupons[businessLine] = [];
      }
      validCoupons[businessLine].push(code);
    }
  });

  let ans = [];
  APPROVED_BUSINESSES.forEach((businessLine) => {
    if (businessLine in validCoupons) {
      ans.push(...validCoupons[businessLine].sort());
    }
  });

  return ans;
}

console.log(
  validateCoupons(["MI", "b_"], ["pharmacy", "pharmacy"], [true, true]),
);
