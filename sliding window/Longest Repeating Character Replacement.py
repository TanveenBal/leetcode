from collections import defaultdict
def characterReplacement(s: str, k: int) -> int:
    length = len(s)
    l, r = 0, 0
    seen = defaultdict(int)
    ans = 0
    frequent = 0
    while r < length:
        seen[s[r]] += 1
        frequent = max(frequent, seen[s[r]])

        while (r - l + 1 - frequent) > k:
            seen[s[l]] -= 1
            l += 1
        ans = max(ans, r - l + 1)
        r += 1

    return ans

print(characterReplacement("XYYX", 2))
print(characterReplacement("AAABABB", 1))
