public class SolutionSearch
{
    public int Search(int[] nums, int target)
    {
        int l = 0, h = nums.Length - 1;

        while (l <= h)
        {
            int m = l + (h - l) / 2;

            if (nums[m] == target)
                return m;

            if (nums[m] <= nums[h]) // right side is in order
            {
                if (target > nums[m] && target <= nums[h])
                    l = m + 1;
                else
                    h = m - 1;
            }
            else // left side is in order
            {
                if (target < nums[m] && target >= nums[l])
                    h = m - 1;
                else
                    l = m + 1;
            }
        }
        return -1;
    }
}
