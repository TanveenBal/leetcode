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
public class SolutionInvertTree
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

    private void dfs(TreeNode node)
    {
        if (node == null)
            return;
        if (node.left != null && node.right != null)
        {
            TreeNode temp = node.left;
            node.left = node.right;
            node.right = temp;
        }
        else if (node.left != null)
        {
            node.right = node.left;
            node.left = null;
        }
        else if (node.right != null)
        {
            node.left = node.right;
            node.right = null;
        }


        dfs(node.left);
        dfs(node.right);
    }
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
            return null;

        dfs(root);
        return root;
    }
}
