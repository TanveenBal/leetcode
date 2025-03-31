from typing import List

def dailyTemperatures(temperatures: List[int]) -> List[int]:
    ans = [0] * len(temperatures)
    stack = [(temperatures[0], 0)] # temp, index

    for i in range(1, len(temperatures)):
        while stack and stack[-1][0] < temperatures[i]:
            _, index = stack.pop()
            ans[index] = i - index
        stack.append((temperatures[i], i))

    return ans

print(dailyTemperatures([30,38,30,36,35,40,28]))
print(dailyTemperatures([22,21,20]))
