class Solution:
    def removeDuplicates(self, s: str) -> str:
        ans = [s[0]]
        for i in range(1, len(s)):
            if len(ans) != 0 and ans[-1] == s[i]:
                ans.pop()
            else:
                ans.append(s[i])

        return "".join(ans)

s = Solution()
print(s.removeDuplicates("abbaca"))
