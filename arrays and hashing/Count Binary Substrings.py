def countBinarySubstrings(s: str) -> int:
    groups = [1]
    ans = 0

    length = len(s)
    for i in range(1, length):
        if s[i - 1] != s[i]:
            groups.append(0)
        groups[-1] += 1

    length = len(groups)
    for i in range(1, length):
        ans += min(groups[i - 1], groups[i])

    return ans


print(countBinarySubstrings("00110011"))
print(countBinarySubstrings("10101"))
