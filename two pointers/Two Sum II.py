def twoSum(numbers: list[int], target: int) -> list[int]:
    l, r = 0, len(numbers) - 1

    while l <= r:
        added = numbers[l] + numbers[r]
        if added > target:
            r -= 1
        elif added < target:
            l += 1
        else:
            return [l, r]

    return []
