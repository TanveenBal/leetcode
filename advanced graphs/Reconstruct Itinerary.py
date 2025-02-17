from collections import defaultdict
def findItinerary(tickets: list[list[str]]) -> list[str]:
    graph = defaultdict(list)
    for src, dest in tickets:
        graph[src].append(dest)

    for src in graph:
        graph[src].sort(reverse=True)

    itin = []

    def dfs(node):
        while graph[node]:
            next_dest = graph[node].pop()
            dfs(next_dest)
        itin.append(node)


    dfs("JFK")
    return itin[::-1]

print(findItinerary([["MUC","LHR"],["JFK","MUC"],["SFO","SJC"],["LHR","SFO"]]))
