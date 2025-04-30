public class SolutionTwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> sumNeeded = new Dictionary<int, int>(); // Key: remainder we are looking for  Value: index unique
        for (int i = 0; i < nums.Length; i++)
        {
            if (sumNeeded.ContainsKey(target - nums[i]))
                return new int[2] { i, sumNeeded[target - nums[i]] };
            sumNeeded[nums[i]] = i;
        }

        return new int[2] { -1, -1 };
    }
}
