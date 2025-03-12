def productExceptSelf(nums: list[int]) -> list[int]:
    totalProd = 1
    zero = -1
    z = False

    for i, num in enumerate(nums):
        if num != 0:
            totalProd *= num
        elif z:
            return [0] * len(nums)
        else:
            zero = i
            z = True

    if zero != -1:
        ans = [0] * len(nums)
        ans[zero] = totalProd
    else:
        ans = nums[:]
        for i, num in enumerate(nums):
            ans[i] = totalProd // num

    return ans

print(productExceptSelf([1, 2, 4, 6]))
print(productExceptSelf([-1, 0, 1, 2, 3]))
print(productExceptSelf([0, 0]))
