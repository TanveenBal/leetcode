from collections import Counter, defaultdict
def checkInclusion(s1: str, s2: str) -> bool:
    len_s1 = len(s1)
    len_s2 = len(s2)

    if len_s1 > len_s2:
        return False

    freq1 = Counter(s1)
    freq2 = defaultdict(int)

    for i in range(len_s1):
        freq2[s2[i]] += 1

    for i in range(len_s1, len_s2):
        if freq1 == freq2:
            return True
        freq2[s2[i - len_s1]] -= 1
        if freq2[s2[i - len_s1]] == 0:
            freq2.pop(s2[i - len_s1])
        freq2[s2[i]] += 1

    if freq1 == freq2:
        return True

    return False

print(checkInclusion("abc", "lecabee"))
print(checkInclusion("adc", "dcda"))
