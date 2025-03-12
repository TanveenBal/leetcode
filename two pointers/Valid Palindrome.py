def isPalindrome(s: str) -> bool:
    l, r = 0, len(s) - 1

    while l <= r:
        left, right = s[l].lower(), s[r].lower()
        print(left, right)
        if not left.isalnum():
            l += 1
        elif not right.isalnum():
            r -= 1
        elif left != right:
            return False
        else:
            l += 1
            r -= 1

    return True

print(isPalindrome("A man, a plan, a canal: Panama"))
