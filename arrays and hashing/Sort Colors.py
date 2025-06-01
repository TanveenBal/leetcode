from typing import List

class Solution:
    def sortColors(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        def swap(arr, i, j):
            arr[i], arr[j] = arr[j], arr[i]

        l, r = 0, len(nums) - 1

        for c in range(len(nums)):
            if l >= r:
                break

            while nums[c] != 1 and l <= c <= r:
                if nums[c] == 0:
                    swap(nums, c, l)
                    l += 1
                elif nums[c] == 2:
                    swap(nums, c, r)
                    r -= 1
