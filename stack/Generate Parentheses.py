def generateParenthesis(n: int) -> list[str]:
    """
    We have two options:
    Option 1: Add opening paren and n -= 1
    Option 2: Add closing paren iff stack has an opening paren
    Do this while backtracking both choices
    """

    ans = []

    def backtrack(stack, n, parens):
        if n == 0 and not stack:
            ans.append(parens)
            return

        if n > 0:
            stack.append('(')
            backtrack(stack, n - 1, parens + '(')
            stack.pop()
        if stack:
            stack.pop()
            backtrack(stack, n, parens + ')')
            stack.append('(')

    backtrack([], n, '')
    return ans

print(generateParenthesis(10))
