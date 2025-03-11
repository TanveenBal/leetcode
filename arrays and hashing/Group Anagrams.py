from collections import defaultdict

def groupAnagrams(strs: list[str]) -> list[list[str]]:
    groups = defaultdict(list)

    for s in strs:
        chars = [0] * 26

        for c in s:
            chars[ord(c) - ord('a')] += 1

        groups[tuple(chars)].append(s)

    return list(groups.values())
