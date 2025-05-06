public class SolutionMaxSubArray
{
    public int MaxSubArray(int[] nums)
    {
        int ans = nums[0];
        int sum = 0;

        foreach (int num in nums)
        {
            sum += num;
            ans = Math.Max(ans, sum);
            if (sum < 0)
                sum = 0;
        }
        return ans;
    }
}
