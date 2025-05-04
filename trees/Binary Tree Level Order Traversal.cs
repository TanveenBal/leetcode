/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class SolutionLevelOrder
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        if (root == null)
            return new List<IList<int>> { };

        Queue<TreeNode> queue = new Queue<TreeNode>();
        List<IList<int>> ans = new List<IList<int>>();

        queue.Enqueue(root);
        while (queue.Count != 0)
        {
            List<int> layer = new List<int>();
            int len = queue.Count;
            for (int i = 0; i < len; ++i)
            {
                TreeNode curr = queue.Dequeue();
                layer.Add(curr.val);
                if (curr.left != null)
                    queue.Enqueue(curr.left);
                if (curr.right != null)
                    queue.Enqueue(curr.right);
            }
            ans.Add(layer);
        }

        return ans;
    }
}
