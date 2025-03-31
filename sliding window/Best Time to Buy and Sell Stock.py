from typing import List

def maxProfit(prices: List[int]) -> int:
    profit = 0
    l, r = 0, 1
    length = len(prices)

    while l < length and r < length:
        buy = prices[l]
        sell = prices[r]
        if buy < sell:
            r += 1
        if buy >= sell:
            l = r
            r += 1
        profit = max(profit, sell - buy)

    return profit

print(maxProfit([7,1,5,3,6,4]))
print(maxProfit([7,6,4,3,1]))
