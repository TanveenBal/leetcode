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
public class SolutionKthSmallest
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    private int count = 0;
    private int smallest = 0;

    private void InOrderTraversal(TreeNode node, int k)
    {
        if (node == null)
            return;

        InOrderTraversal(node.left, k);

        count++;
        if (count == k)
        {
            smallest = node.val;
            return;
        }

        InOrderTraversal(node.right, k);
    }

    public int KthSmallest(TreeNode root, int k)
    {
        count = 0;
        smallest = 0;
        InOrderTraversal(root, k);
        return smallest;
    }
}

