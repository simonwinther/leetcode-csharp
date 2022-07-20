using System;

namespace leetcode_csharp
{
    public class DiameterBinaryTree
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

        int result = -1;
        public int dfs(TreeNode root)
        {
            if (root == null)
                return -1;

            int left = 1 + dfs(root.left);
            int right = 1 + dfs(root.right);
            result = Math.Max(result, (left + right));
            return Math.Max(left, right);
        }

        public int DiameterOfBinaryTree(TreeNode root)
        {
            dfs(root);
            return result;
        }
    }
}