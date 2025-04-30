public class SolutionGroupAnagrams
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();

        foreach (string s in strs)
        {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string sortedS = new string(chars);

            if (!map.ContainsKey(sortedS))
                map[sortedS] = new List<string>();
            map[sortedS].Add(s);
        }

        IList<IList<string>> ans = new List<IList<string>>();
        foreach (var (_, anagrams) in map)
            ans.Add(anagrams);

        return ans;
    }
}
