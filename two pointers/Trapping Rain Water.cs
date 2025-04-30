public class SolutionTrap
{
    public int Trap(int[] height)
    {
        if (height == null || height.Length == 0)
            return 0;

        int maxL = 0, maxR = 0, ans = 0;
        int l = 0, r = height.Length - 1;

        while (l < r)
        {
            maxL = Math.Max(maxL, height[l]);
            maxR = Math.Max(maxR, height[r]);
            int water = 0;
            if (maxL < maxR)
            {
                ++l;
                water = maxL - height[l];
            }
            else
            {
                --r;
                water = maxR - height[r];
            }

            if (water > 0)
                ans += water;
        }

        return ans;
    }
}
