public class SolutionFindMin
{
    public int FindMin(int[] nums)
    {
        int l = 0, h = nums.Length - 1;
        int ans = int.MaxValue;

        while (l < h)
        {
            int m = ((h - l) / 2) + l;
            ans = Math.Min(ans, nums[m]);

            if (nums[m] > nums[h])
                l = m + 1;
            else
                h = m - 1;
        }

        return Math.Min(ans, nums[l]);
    }
}
