class Solution:
    def alternateDigitSum(self, n: int) -> int:
        ans, sign = 0, 1
        n = str(n)
        for i in range(len(n)):
            ans += sign * int(n[i])
            sign *= -1

        return ans


sol = Solution()
print(sol.alternateDigitSum(521))
