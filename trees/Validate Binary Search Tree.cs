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
public class SolutionIsValidBST
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    private bool valid(TreeNode node, int min, int max)
    {
        if (node == null)
            return true;

        if (!(min < node.val && node.val < max))
            return false;

        return valid(node.left, min, node.val) && valid(node.right, node.val, max);
    }

    public bool IsValidBST(TreeNode root)
    {
        return valid(root, int.MinValue, int.MaxValue);
    }
}
