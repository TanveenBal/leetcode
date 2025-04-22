from typing import List


class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        insert = 0
        length = len(nums)

        for i in range(length):
            if nums[i] != 0:
                nums[insert] = nums[i]
                insert += 1

        for i in range(insert, length):
            nums[i] = 0

        print(nums)


s = Solution()
print(s.moveZeroes([0,1,0,3,12]))
print(s.moveZeroes([0,1]))
print(s.moveZeroes([0]))
print(s.moveZeroes([1,0,0]))
