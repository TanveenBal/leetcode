public class SolutionMaxArea
{
    public int MaxArea(int[] height)
    {
        int ans = 0;
        int l = 0;
        int r = height.Length - 1;

        while (l < r)
        {
            int lH = height[l];
            int rH = height[r];
            int water = (r - l) * Math.Min(rH, lH);
            if (lH < rH)
                ++l;
            else
                --r;

            ans = Math.Max(ans, water);
        }
        return ans;
    }
}
