public class SolutionBinarySearch
{
    private int BinarySearch(int[] nums, int target, int l, int h)
    {
        if (l > h)
            return -1;
        int m = l + ((h - l) / 2);

        if (target > nums[m])
            return BinarySearch(nums, target, m + 1, h);
        else if (target < nums[m])
            return BinarySearch(nums, target, l, m - 1);
        else
            return m;
    }
    public int Search(int[] nums, int target)
    {
        return BinarySearch(nums, target, 0, nums.Length - 1);
    }
}
