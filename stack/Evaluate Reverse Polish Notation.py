def evalRPN(tokens: list[str]) -> int:
    stack = []

    for i in range(len(tokens)):
        t = tokens[i]
        if t.strip('-').isdigit():
            stack.append(int(t))
        else:
            r = stack.pop()
            l = stack.pop()
            if t == '+':
                stack.append(l + r)
            elif t == '-':
                stack.append(l - r)
            elif t == '/':
                stack.append(int(l / r))
            else:
                stack.append(l * r)

    return stack.pop()

print(evalRPN(["10","6","9","3","+","-11","*","/","*","17","+","5","+"]))
print(evalRPN(["3","-4","+"]))
