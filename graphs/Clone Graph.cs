public class Node
{
    public int val;
    public IList<Node> neighbors;

    public Node()
    {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val)
    {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors)
    {
        val = _val;
        neighbors = _neighbors;
    }
}


public class SolutionCloneGraph
{
    public Node CloneGraph(Node node)
    {
        if (node == null)
            return null;

        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(node);
        map[node] = new Node(node.val);

        while (queue.Count > 0)
        {
            Node curr = queue.Dequeue();

            foreach (Node n in curr.neighbors)
            {
                if (!map.ContainsKey(n))
                {
                    // create new child node if it does not exist and map it
                    map[n] = new Node(n.val);
                    queue.Enqueue(n);
                }

                // add neighbor to curr nodes neighbors list
                map[curr].neighbors.Add(map[n]);
            }
        }

        return map[node];
    }
}
