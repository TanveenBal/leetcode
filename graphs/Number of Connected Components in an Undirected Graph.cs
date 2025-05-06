public class UnionFind
{
    public Dictionary<int, int> parents;
    public Dictionary<int, int> ranks;

    public UnionFind()
    {
        parents = new Dictionary<int, int>();
        ranks = new Dictionary<int, int>();
    }

    public int find(int node)
    {
        if (parents[node] != node)
            parents[node] = find(parents[node]);
        return parents[node];
    }

    public void union(int node1, int node2)
    {
        int parent1 = find(node1);
        int parent2 = find(node2);

        if (parent1 == parent2)
            return;

        // union by rank
        if (ranks[parent1] > ranks[parent2])
        {
            parents[parent2] = parent1;
        }
        else if (ranks[parent1] < ranks[parent2])
        {
            parents[parent1] = parent2;
        }
        else
        {
            parents[parent2] = parent1;
            ranks[parent1]++;
        }
    }
}

class SolutionCountComponents
{
    public int CountComponents(int n, int[][] edges)
    {
        UnionFind uf = new UnionFind();

        // Initialize each node's parent and rank
        for (int i = 0; i < n; ++i)
        {
            uf.parents[i] = i;
            uf.ranks[i] = 0;
        }

        foreach (var edge in edges)
            uf.union(edge[0], edge[1]);

        HashSet<int> components = new HashSet<int>();
        for (int i = 0; i < n; ++i)
            components.Add(uf.find(i));

        return components.Count;
    }
    /*private Dictionary<int, List<int>> graph;*/
    /*private HashSet<int> visited;*/
    /*private int components;*/
    /**/
    /*private void dfs(int node, int prev)*/
    /*{*/
    /*    if (visited.Contains(node))*/
    /*        return;*/
    /**/
    /*    visited.Add(node);*/
    /**/
    /*    foreach (int neighbor in graph[node])*/
    /*    {*/
    /*        if (neighbor == prev)*/
    /*            continue;*/
    /**/
    /*        dfs(neighbor, node);*/
    /*    }*/
    /*}*/
    /**/
    /*public int CountComponents(int n, int[][] edges)*/
    /*{*/
    /*    graph = new Dictionary<int, List<int>>();*/
    /*    visited = new HashSet<int>();*/
    /*    components = 0;*/
    /**/
    /*    for (int i = 0; i < n; ++i)*/
    /*        graph[i] = new List<int>();*/
    /**/
    /*    foreach (int[] edge in edges)*/
    /*    {*/
    /*        graph[edge[0]].Add(edge[1]);*/
    /*        graph[edge[1]].Add(edge[0]);*/
    /*    }*/
    /**/
    /*    for (int node = 0; node < n; ++node)*/
    /*    {*/
    /*        if (!visited.Contains(node))*/
    /*        {*/
    /*            ++components;*/
    /*            dfs(node, -1);*/
    /*        }*/
    /*    }*/
    /**/
    /*    return components;*/
    /*}*/
}
