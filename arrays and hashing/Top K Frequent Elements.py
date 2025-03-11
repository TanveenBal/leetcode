import heapq
from collections import defaultdict

def topKFrequent(nums: list[int], k: int) -> list[int]:
    freq = defaultdict(int)
    for num in nums:
        freq[num] += 1

    topK = []

    for num, freq in freq.items():
        heapq.heappush(topK, (-freq, num))

    ans = []
    for _ in range(k):
        ans.append(heapq.heappop(topK)[1])

    return ans
