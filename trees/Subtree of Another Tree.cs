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
public class SolutionIsSubtree
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

    private bool isSame(TreeNode r, TreeNode s)
    {
        if (r == null && s == null)
            return true;

        if (r == null || s == null)
            return false;

        if (r.val != s.val)
            return false;

        return isSame(r.left, s.left) && isSame(r.right, s.right);
    }

    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        Stack<TreeNode> stack = new Stack<TreeNode> { };
        stack.Push(root);

        Console.WriteLine(stack.Count);
        while (stack.Count != 0)
        {
            TreeNode curr = stack.Pop();
            Console.WriteLine(curr.val);
            if (curr.val == subRoot.val && isSame(curr, subRoot))
            {
                Console.WriteLine("here?");
                return true;
            }
            if (curr.right != null)
                stack.Push(curr.right);
            if (curr.left != null)
                stack.Push(curr.left);
        }

        return false;
    }
}
