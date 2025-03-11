def isAnagram(s: str, t: str) -> bool:
    if len(s) != len(t):
        return False

    chars = {}

    for char in s:
        if char in chars:
            chars[char] += 1
        else:
            chars[char] = 1

    for char in t:
        if char in chars:
            chars[char] -= 1
            if chars[char] == -1:
                return False
        else:
            return False

    return True
