/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function (prices) {
  // buy if the next one is higher, sell once the next one is a loss number
  let profit = 0;

  for (let i = 1; i < prices.length; i++) {
    if (prices[i] > prices[i - 1]) {
      profit += prices[i] - prices[i - 1];
    }
  }

  return profit;
};
