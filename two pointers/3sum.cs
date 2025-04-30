public class SolutionThreeSum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        List<IList<int>> ans = new List<IList<int>>();
        HashSet<string> seen = new HashSet<string>();

        for (int i = 0; i < nums.Length - 2; ++i)
        {
            if (nums[i] > 0) break;
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int l = i + 1;
            int r = nums.Length - 1;

            while (l < r)
            {
                int sum = nums[i] + nums[l] + nums[r];
                if (sum < 0) ++l;
                else if (sum > 0) --r;
                else
                {
                    List<int> triplet = new List<int> { nums[i], nums[l], nums[r] };
                    string key = string.Join(",", triplet);
                    if (!seen.Contains(key))
                    {
                        seen.Add(key);
                        ans.Add(triplet);
                    }
                    ++l;
                    --r;
                    while (l < r && nums[l] == nums[l - 1]) ++l;
                    while (l < r && nums[r] == nums[r + 1]) --r;
                }
            }
        }

        return ans;
    }
}
