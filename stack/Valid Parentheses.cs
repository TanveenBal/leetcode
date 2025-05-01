public class SolutionIsValid
{
    public bool IsValid(string s)
    {
        if (s.Length == 1)
            return false;

        Stack<char> open = new Stack<char>();

        HashSet<char> opening = new HashSet<char> { '(', '[', '{' };

        for (int i = 0; i < s.Length; ++i)
        {
            char c = s[i];
            if (opening.Contains(c))
                open.Push(c);
            else
            {
                if (open.Count <= 0)
                    return false;

                char popped = open.Pop();
                if (c == ')' && popped != '(')
                    return false;
                if (c == ']' && popped != '[')
                    return false;
                if (c == '}' && popped != '{')
                    return false;
            }
        }
        return open.Count == 0;
    }
}
