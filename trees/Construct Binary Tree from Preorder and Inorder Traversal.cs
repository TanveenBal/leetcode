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
public class SolutionBuildTree
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

    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        if (preorder.Length == 0 || inorder.Length == 0)
            return null;

        TreeNode root = new TreeNode(preorder[0]);
        int mid = Array.IndexOf(inorder, preorder[0]);
        root.left = BuildTree(preorder[1..(mid + 1)], inorder[..mid]);
        root.right = BuildTree(preorder[(mid + 1)..], inorder[(mid + 1)..]);
        return root;
    }
}
