public class SolutionLengthOfLongestSubstring
{
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> seen = new Dictionary<char, int>();
        int start = 0, maxLength = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (seen.ContainsKey(s[i]) && seen[s[i]] >= start)
                start = seen[s[i]] + 1;

            seen[s[i]] = i;
            maxLength = Math.Max(maxLength, i - start + 1);
        }

        return maxLength;
    }
}
