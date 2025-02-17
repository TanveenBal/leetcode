from collections import defaultdict
import heapq
def networkDelayTime(times: list[list[int]], n: int, k: int) -> int:
    graph = defaultdict(list)
    for u, v, w in times:
        graph[u].append((w, v))

    heap = [(0, k)]
    for edge in graph[k]:
        heapq.heappush(heap, edge)
    time = -1
    seen = set()
    seen_len = 0
    while heap:
        weight, node = heapq.heappop(heap)
        if node in seen:
            continue
        time = weight
        seen.add(node)
        seen_len += 1
        if seen_len == n:
            return time
        for w, v in graph[node]:
            if v not in seen:
                heapq.heappush(heap, (w + time, v))

    if seen_len != n:
        return -1
    return time


print(networkDelayTime([[2,1,1],[2,3,1],[3,4,1]], 4, 2))
print(networkDelayTime([[1,2,1],[2,1,3]], 2, 2))
