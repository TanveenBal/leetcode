public class SolutionMinWindow
{
    public string MinWindow(string s, string t)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return "";

        Dictionary<char, int> need = new Dictionary<char, int>();

        foreach (char c in t)
        {
            if (!need.ContainsKey(c)) need[c] = 0;
            need[c]++;
        }

        Dictionary<char, int> have = new Dictionary<char, int>();
        int l = 0, r = 0;
        int valid = 0;
        int start = 0, end = int.MaxValue;

        while (r < s.Length)
        {
            char c = s[r];
            r++;

            if (need.ContainsKey(c))
            {
                if (!have.ContainsKey(c)) have[c] = 0;
                have[c]++;
                if (have[c] == need[c]) valid++;
            }

            while (valid == need.Count)
            {
                if (r - l < end)
                {
                    start = l;
                    end = r - l;
                }

                char d = s[l];
                l++;

                if (need.ContainsKey(d))
                {
                    if (have[d] == need[d]) valid--;
                    have[d]--;
                }
            }
        }

        return end == int.MaxValue ? "" : s.Substring(start, end);
    }
}
