import math
def calculateMaxQualityScore(impactFactor: int, ratings: list[int]):
    r = 0
    prev = 0
    strat1 = float("-inf")
    while r < len(ratings):
        curr = prev + ratings[r] * (impactFactor - 1)
        strat1 = max(strat1, curr)
        if curr < prev:
            prev = 0
        else:
            prev = curr
        r += 1
    r = 0
    prev = 0
    strat2 = float("inf")
    while r < len(ratings):
        if ratings[r] > 0:
            curr = prev + math.ceil(ratings[r] / impactFactor)
        elif ratings[r] < 0:
            curr = prev + math.floor(ratings[r] / impactFactor)
        else:
            curr = prev + ratings[r]

        strat2 = min(strat2, curr)
        if curr > prev:
            prev = 0
        else:
            prev = curr
        r += 1

    return strat1 + sum(ratings)

print(calculateMaxQualityScore(3, [5, -3, -3, 2, 4]))
