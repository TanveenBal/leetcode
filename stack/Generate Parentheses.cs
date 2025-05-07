public class SolutionGenerateParenthesis
{
    private List<string> ans;
    private int parens;

    private void backtrack(int open, int close, string curr)
    {
        if (open > parens || close > parens)
            return;

        if (open == parens && close == parens)
        {
            ans.Add(curr);
            return;
        }

        if (close < open)
        {
            backtrack(open, close + 1, curr + ")");
            if (open < parens)
                backtrack(open + 1, close, curr + "(");

        }
        else
            backtrack(open + 1, close, curr + "(");
    }

    public IList<string> GenerateParenthesis(int n)
    {
        ans = new List<string>();
        parens = n;

        backtrack(0, 0, "");
        return ans;
    }
}
