public class SolutionValidTree
{
    private HashSet<int> visited;
    private Dictionary<int, List<int>> nodes;

    private bool dfs(int node, int prev)
    {
        // if visited return false as we should not have cycles in a tree
        if (visited.Contains(node))
            return false;
        visited.Add(node);

        foreach (int neighbor in nodes[node])
        {
            // since we have undirected edges, we must skip the edge that we just used
            if (neighbor == prev)
                continue;

            // if the dfs returns false also return false
            if (!dfs(neighbor, node))
                return false;
        }

        // all neighbors of this node reach the end with no cycle
        return true;
    }
    public bool ValidTree(int n, int[][] edges)
    {
        if (edges.Length == 0) return true;

        nodes = new Dictionary<int, List<int>>();
        visited = new HashSet<int>();

        // all n nodes initialized with a list of neighbors
        for (int i = 0; i < n; ++i)
            nodes[i] = new List<int>();

        // add edge both direction as it is undirected
        for (int i = 0; i < edges.Length; ++i)
        {
            nodes[edges[i][0]].Add(edges[i][1]);
            nodes[edges[i][1]].Add(edges[i][0]);
        }

        // only dfs the first node as it is connected graph
        if (!dfs(0, -1))
            return false;

        // if connected we should have visited all nodes with one dfs
        return visited.Count == n;
    }
}
