public class SolutionCombinationSum
{
    private List<IList<int>> ans;
    private int[] candidates;
    private int target;

    private void Backtrack(int index, int sum, List<int> curPath)
    {
        if (index >= candidates.Length || sum > target)
            return;

        if (sum == target)
        {
            ans.Add(new List<int>(curPath));
            return;
        }

        curPath.Add(candidates[index]);
        Backtrack(index, sum + candidates[index], curPath);
        curPath.Remove(candidates[index]);
        Backtrack(index + 1, sum, curPath);
    }
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        ans = new List<IList<int>>();
        this.candidates = candidates;
        this.target = target;


        Backtrack(0, 0, new List<int>());
        return ans;
    }
}
