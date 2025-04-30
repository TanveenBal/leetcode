public class SolutionIsAnagram
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> mapS = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (mapS.ContainsKey(c))
                mapS[c]++;
            else
                mapS[c] = 1;
        }
        Dictionary<char, int> mapT = new Dictionary<char, int>();
        foreach (char c in t)
        {
            if (mapT.ContainsKey(c))
                mapT[c]++;
            else
                mapT[c] = 1;
        }

        foreach ((char k, int v) in mapS)
        {
            if (mapT.ContainsKey(k))
            {
                if (mapT[k] != v)
                    return false;
            }
            else
                return false;
        }
        return true;
    }
}
