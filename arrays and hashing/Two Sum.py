def twoSum(nums: list[int], target: int) -> list[int]:
    diffs = {}

    for i, num in enumerate(nums):
        diff = target - num
        if num in diffs:
            return [diffs[num], i]
        else:
            diffs[diff] = i

    return []

print(twoSum([3,4,5,6], 7))
