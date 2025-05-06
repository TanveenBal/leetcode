public class SolutionCanFinish
{
    private HashSet<int> visited;
    private Dictionary<int, List<int>> prereqs;

    private bool dfs(int course)
    {
        if (visited.Contains(course))
            return false;

        if (prereqs[course].Count == 0)
            return true;

        visited.Add(course);

        foreach (int pre in prereqs[course])
        {
            if (!dfs(pre))
                return false;
        }
        visited.Remove(course);
        prereqs[course] = new List<int>();

        return true;
    }
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        prereqs = new Dictionary<int, List<int>>();
        visited = new HashSet<int>();

        for (int i = 0; i < numCourses; i++)
            prereqs[i] = new List<int>();

        foreach (int[] pair in prerequisites)
            prereqs[pair[0]].Add(pair[1]);

        for (int i = 0; i < numCourses; i++)
        {
            if (!dfs(i))
                return false;
        }

        return true;
    }
}
