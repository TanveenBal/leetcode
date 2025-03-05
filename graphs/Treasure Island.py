from collections import deque
def treasureIsland(map: list[list[str]]) -> list[tuple[int, int]]:
    queue = deque([[0, 0]])
    seen = set([(0, 0)])
    rows = len(map)
    cols = len(map[0])
    parent = { (0, 0): (0, 0) }
    route = []

    dirs = [(1, 0), (0, -1), (-1, 0), (0, 1)]
    while queue:
        currx, curry = queue.popleft()
        for dirx, diry in dirs:
            new_dirx, new_diry = currx + dirx, curry + diry
            if ((new_dirx, new_diry) in seen or 
                not (0 <= new_dirx < rows) or 
                not (0 <= new_diry < cols) or 
                map[new_dirx][new_diry] == "D"):
                continue
            seen.add((new_dirx, new_diry))
            parent[(new_dirx, new_diry)] = (currx, curry)
            if map[new_dirx][new_diry] == "X":
                cur = (new_dirx, new_diry)
                route = [cur]
                while cur != (0, 0):
                    cur = parent[cur]
                    route.append(cur)
                route.reverse()
                return route
            else:
                queue.append([new_dirx, new_diry])

    return route


print(treasureIsland([['O', 'O', 'O', 'O'],['D', 'O', 'D', 'O'],['O', 'O', 'O', 'O'],['X', 'D', 'D', 'O']]))
