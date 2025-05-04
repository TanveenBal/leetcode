/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public string serialize(TreeNode root)
    {
        List<string> result = new List<string>();
        serializeHelper(root, result);
        return string.Join(",", result);
    }

    private void serializeHelper(TreeNode node, List<string> result)
    {
        if (node == null)
        {
            result.Add("");
            return;
        }

        result.Add(node.val.ToString());
        serializeHelper(node.left, result);
        serializeHelper(node.right, result);
    }

    public TreeNode deserialize(string data)
    {
        if (string.IsNullOrEmpty(data)) return null;

        Queue<string> nodes = new Queue<string>(data.Split(','));
        return deserializeHelper(nodes);
    }

    private TreeNode deserializeHelper(Queue<string> nodes)
    {
        if (nodes.Count == 0) return null;

        string val = nodes.Dequeue();
        if (val == "") return null;

        TreeNode node = new TreeNode(int.Parse(val));
        node.left = deserializeHelper(nodes);
        node.right = deserializeHelper(nodes);

        return node;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));
