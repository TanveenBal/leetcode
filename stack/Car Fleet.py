from typing import List

def carFleet(target: int, position: List[int], speed: List[int]) -> int:
        cars = sorted(zip(position, speed), reverse=True)

        stack = []
        for pos, spd in cars:
            time = (target - pos) / spd
            if not stack or time > stack[-1]:
                stack.append(time)

        return len(stack)

print(carFleet(12, [10, 8, 0, 5, 3], [2, 4, 1, 1, 3]))
