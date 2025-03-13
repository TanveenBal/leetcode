def maxArea(height: list[int]) -> int:
    l, r = 0, len(height) - 1
    ans = 0

    while l < r:
        lh, rh = height[l], height[r]
        area = min(lh, rh) * (r - l)
        ans = max(ans, area)

        if lh < rh:
            l += 1
        else:
            r -= 1


    return ans

print(maxArea([1,8,6,2,5,4,8,3,7]))
print(maxArea([1,2,1]))
