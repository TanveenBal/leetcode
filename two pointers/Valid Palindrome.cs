public class SolutionIsPalindrome
{
    public bool IsPalindrome(string s)
    {
        int l = 0;
        int r = s.Length - 1;

        while (l < r)
        {
            while (l < r && !char.IsLetterOrDigit(s[l]))
                l++;
            while (l < r && !char.IsLetterOrDigit(s[r]))
                r--;

            char left = char.ToLower(s[l]);
            char right = char.ToLower(s[r]);

            if (left != right)
                return false;
            l++;
            r--;
        }

        return true;
    }
}
