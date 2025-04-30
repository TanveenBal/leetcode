public class SolutionCharacterReplacement
{
    public int CharacterReplacement(string s, int k)
    {
        Dictionary<char, int> count = new Dictionary<char, int> { };

        int ans = 0;

        int start = 0, maxf = 0;

        for (int i = 0; i < s.Length; ++i)
        {
            if (count.ContainsKey(s[i]))
                ++count[s[i]];
            else
                count[s[i]] = 1;

            maxf = Math.Max(maxf, count[s[i]]);


            while ((i - start + 1) - maxf > k)
            {
                --count[s[start]];
                ++start;
            }
            ans = Math.Max(ans, i - start + 1);
        }

        return ans;
    }
}
