public class SolutionSearchInsertIterative
{
    public int SearchInsert(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (nums[mid] > target)
                high = mid - 1;
            else if (nums[mid] < target)
                low = mid + 1;
            else
                return mid;
        }

        return low;
    }
}



public class SolutionSearchInsertRecursive
{
    private int BinarySearch(int[] nums, int target, int low, int high)
    {
        if (low > high)
            return low;

        int mid = low + (high - low) / 2;

        if (nums[mid] > target)
            return BinarySearch(nums, target, low, mid - 1);
        else if (nums[mid] < target)
            return BinarySearch(nums, target, mid + 1, high);
        else
            return mid;
    }

    public int SearchInsert(int[] nums, int target)
    {
        return BinarySearch(nums, target, 0, nums.Length - 1);
    }
}

