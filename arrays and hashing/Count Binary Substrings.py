def countBinarySubstrings(s: str) -> int:
    ans = 0
    prev_run_length = 0 
    cur_run_length = 1

    for i in range(1, len(s)):
        if s[i] == s[i - 1]:
            cur_run_length += 1
        else:
            ans += min(prev_run_length, cur_run_length)
            prev_run_length = cur_run_length
            cur_run_length = 1

    ans += min(prev_run_length, cur_run_length)

    return ans

# def countBinarySubstrings(s: str) -> int:
#     groups = [1]
#     ans = 0
#
#     length = len(s)
#     for i in range(1, length):
#         if s[i - 1] != s[i]:
#             groups.append(0)
#         groups[-1] += 1
#
#     length = len(groups)
#     for i in range(1, length):
#         ans += min(groups[i - 1], groups[i])
#
#     return ans

# def countBinarySubstrings(s: str) -> int:
#     ans = 0
#
#     length = len(s)
#     for i in range(1, length):
#         l, r = i - 1, i
#         l_char = s[l]
#         r_char = s[r]
#         if l_char == r_char:
#             continue
#         while l >= 0 and r < length and s[l] == l_char and s[r] == r_char:
#             ans += 1
#             l -= 1
#             r += 1
#
#     return ans

print(countBinarySubstrings("00110011"))
print(countBinarySubstrings("10101"))
