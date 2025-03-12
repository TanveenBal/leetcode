def longestConsecutive(nums: list[int]) -> int:
    seen = set(nums)

    ans = 0
    for num in nums:
        cur_ans = 1
        cur_num = num - 1
        while cur_num in seen:
            cur_ans += 1
            cur_num -= 1
        ans = max(ans, cur_ans)

    return ans


print(longestConsecutive([2,20,4,10,3,4,5]))
print(longestConsecutive([0,3,2,5,4,6,1,1]))
