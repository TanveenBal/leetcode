public class SolutionReverseString
{
    public void ReverseString(char[] s)
    {
        for (int l = 0, r = s.Length - 1; l < r; (s[l], s[r]) = (s[r], s[l]), --r, ++l) { }
    }
}
