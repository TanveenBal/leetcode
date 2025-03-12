def threeSum(nums: list[int]) -> list[list[int]]:
    nums.sort()
    ans = []

    for i, num in enumerate(nums):
        if num > 0:
            break
        if i > 0 and num == nums[i - 1]:
            continue
        l, r = i + 1, len(nums) - 1

        while l < r:
            left, right = nums[l], nums[r]
            added = num + left + right
            if added > 0:
                r -= 1
            elif added < 0:
                l += 1
            else:
                ans.append([num, left, right])
                l += 1
                r -= 1
                while nums[l] == nums[l - 1] and l < r:
                        l += 1

    return ans

print(threeSum([-1,0,1,2,-1,-4]))
