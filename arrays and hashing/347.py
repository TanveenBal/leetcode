import heapq

class Solution:
    def topKFrequent(self, nums, k: int):
        count = {}
        heap = []

        for num in nums:
            if num in count:
                count[num] += 1
            else:
                count[num] = 1

        revmap = {}

        for num, cnt in count.items():
            if cnt in revmap:
                revmap[cnt].append(num)
            else:
                revmap[cnt] = [num]
                heapq.heappush(-cnt, heap)


        ans = []

        while k != 0:
            curr = heapq.heappop(heap)
            for num in revmap[-curr]:
                ans.append(num)
                k -= 1

        return ans
