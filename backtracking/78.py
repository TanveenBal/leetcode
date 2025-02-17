def subsets(nums):
    ans = []
    def backtrack(index, curr):
        nonlocal ans
        ans.append(curr[:])
        for i in range(index, len(nums)):
            curr.append(nums[i])
            backtrack(i + 1, curr)
            curr.pop()
    backtrack(0, [])
    return ans


print(subsets([1, 2, 3]))
