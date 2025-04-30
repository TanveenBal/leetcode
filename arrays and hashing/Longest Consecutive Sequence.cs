public class SolutionLongestConsecutive
{
    public int LongestConsecutive(int[] nums)
    {
        Dictionary<int, int> links = new Dictionary<int, int>();
        int ans = 0;

        foreach (int num in nums)
        {
            if (!links.ContainsKey(num))
            {
                int left = 0;
                int right = 0;
                if (links.ContainsKey(num + 1))
                    right = links[num + 1];
                if (links.ContainsKey(num - 1))
                    left = links[num - 1];

                links[num] = left + right + 1;
                links[num - left] = links[num];
                links[num + right] = links[num];
                ans = Math.Max(ans, links[num]);
            }
        }
        return ans;
    }
}
