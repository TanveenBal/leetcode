import heapq
def findMaxValue(factor: list[int], data: list[list[int]], x: int):
    ans = 0
    n = len(data)
    ansmaxheap = []

    for row in range(n):
        maxheap = []
        for val in data[row]:
            heapq.heappush(maxheap, -val)
        for _ in range(factor[row]):
            heapq.heappush(ansmaxheap, heapq.heappop(maxheap))

    for _ in range(x):
        if not ansmaxheap:
            return -1
        ans += -heapq.heappop(ansmaxheap)

    return ans

print(findMaxValue([1, 2, 1], [[1, 2, 3], [4, 5, 6], [7, 8, 9]], 2))
