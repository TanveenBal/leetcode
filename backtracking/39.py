def combinationSum(nums, target: int):
    ans = []
    def backtrack(i, arr, count):
        nonlocal ans
        nonlocal nums
        if count == target:
            ans.append(arr[:])
            return
        if count > target or i >= len(nums):
            return

        backtrack(i + 1, arr[:], count)
        arr.append(nums[i])
        backtrack(i, arr[:], count + nums[i])


    backtrack(0, [], 0)
    return ans

print(combinationSum([2, 3, 6, 7], 7))
