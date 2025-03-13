def isValid(s: str) -> bool:
    """
    we run into a closing char that matches opening at top of stack we pop
    else we need to return false
    if it is an opening char then we add it to the stack
    """

    if len(s) <= 1:
        return False
    stack = []

    open = set(['(', '[', '{'])
    for c in s:
        if c in open:
            stack.append(c)
        else:
            if stack:
                top = stack.pop()
            else:
                return False
            if c == ')' and top != '(':
                return False
            elif c == ']' and top != '[':
                return False
            elif c == '}' and top != '{':
                return False

    return not stack

print(isValid("[]"))
print(isValid("([{}])"))
print(isValid("[(])"))
print(isValid("(("))
