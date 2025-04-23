public class Solution
{
    private bool dfs(int[][] graph, Dictionary<int, bool> set, int node)
    {
        foreach (int neighbor in graph[node])
        {
            if (!set.ContainsKey(neighbor))
            {
                set[neighbor] = !set[node];
                if (!dfs(graph, set, neighbor))
                    return false;
            }
            else if (set[neighbor] == set[node])
                return false;
        }
        return true;
    }

    public bool IsBipartite(int[][] graph)
    {
        var set = new Dictionary<int, bool>();

        for (int node = 0; node < graph.Length; node++)
        {
            if (!set.ContainsKey(node))
            {
                set[node] = false;
                if (!dfs(graph, set, node))
                    return false;
            }
        }

        return true;
    }
}
