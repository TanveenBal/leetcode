from collections import defaultdict
import heapq
def kClosest(points: list[list[int]], k: int) -> list[list[int]]:
    ans = []
    minheap = []

    for x, y in points:
        euc_dist = (x*x) + (y*y)
        heapq.heappush(minheap, (euc_dist, [x, y])) 

    for _ in range(k):
        _, coords = heapq.heappop(minheap)
        ans.append(coords)

    return ans

# def kClosest(points: list[list[int]], k: int) -> list[list[int]]:
#     ans = []
#     maxheap = []
#     currk = 0
#     map = defaultdict(list)
#
#     for x, y in points:
#         euc_dist = -((x*x) + (y*y))
#         if currk < k:
#             heapq.heappush(maxheap, euc_dist)
#             map[euc_dist].append([x, y])
#             currk += 1
#         else:
#             currmax = heapq.heappop(maxheap)
#             if euc_dist > currmax:
#                 map[euc_dist].append([x, y])
#                 heapq.heappush(maxheap, euc_dist)
#             else:
#                 heapq.heappush(maxheap, currmax)
#
#     for euc_dist in maxheap:
#         ans.append(map[euc_dist].pop())
#
#     return ans


print(kClosest([[1,3],[-2,2]], 1))
print(kClosest([[3,3],[5,-1],[-2,4]], 2))
