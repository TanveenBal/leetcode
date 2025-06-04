from typing import List

class Solution:
    def subsetXORSum(self, nums: List[int]) -> int:
        result = 0

        def backtrack(index: int, current_xor: int):
            nonlocal result
            if index == len(nums):
                result += current_xor
                return
            backtrack(index + 1, current_xor ^ nums[index])
            backtrack(index + 1, current_xor)

        backtrack(0, 0)
        return result

s = Solution()
print(s.subsetXORSum([5, 1, 6]))
print(s.subsetXORSum([3, 4, 5, 6, 7, 8]))
