/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class SolutionLowestCommonAncestor
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        TreeNode LCA = root;

        while (LCA != null)
        {
            if (LCA.val > p.val && LCA.val > q.val)
                LCA = LCA.left;
            else if (LCA.val < p.val && LCA.val < q.val)
                LCA = LCA.right;
            else
                return LCA;
        }

        return LCA;
    }
}
