def lengthOfLongestSubstring(s: str) -> int:
    l, r = 0, 0
    ans = 0
    seen = {}

    while r < len(s):
        if s[r] in seen:
            ans = max(ans, r - l)
            new_l = seen[s[r]] + 1
            while l < new_l:
                seen.pop(s[l])
                l += 1

        seen[s[r]] = r
        r += 1

    if l != r:
        ans = max(ans, r - l)
    return ans

print(lengthOfLongestSubstring("abcabcbb"))
