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
public class Solution
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    private int ans = int.MinValue;

    private int dfs(TreeNode node)
    {
        if (node == null)
            return 0;
        int leftMax = Math.Max(dfs(node.left), 0);
        int rightMax = Math.Max(dfs(node.right), 0);

        ans = Math.Max(ans, node.val + leftMax + rightMax);
        return node.val + Math.Max(leftMax, rightMax);
    }
    public int MaxPathSum(TreeNode root)
    {
        dfs(root);
        return ans;
    }
}
