public class SolutionRemoveDuplicateIntegers
{
    public int RemoveDuplicates(int[] nums)
    {
        int k = 0;
        HashSet<int> seen = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!seen.Contains(nums[i]))
            {
                nums[k] = nums[i];
                seen.Add(nums[i]);
                k++;
            }
        }
        return k;
    }
}
