public class SolutionCanConstruct
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        foreach (char c in magazine)
        {
            if (freq.ContainsKey(c))
                freq[c]++;
            else
                freq.Add(c, 1);
        }

        foreach (char c in ransomNote)
        {
            if (freq.ContainsKey(c))
            {
                freq[c]--;
                if (freq[c] < 0)
                    return false;
            }
            else
                return false;
        }
        return true;
    }
}
