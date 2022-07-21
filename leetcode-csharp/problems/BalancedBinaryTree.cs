using System;

namespace leetcode_csharp {
    public class BalencedBinaryTree {
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

        public bool IsBalanced(TreeNode root) {
            return dfs(root).Item1;
        }

        public Tuple<bool, int> dfs(TreeNode root){
            if (root == null)
                return new Tuple<bool, int>(true, 0);
            
            var left = dfs(root.left);
            var right = dfs(root.right);

            var balanced = left.Item1 && right.Item1 && (Math.Abs(left.Item2 - right.Item2) <= 1);

            return new Tuple<bool, int>(balanced, 1 + Math.Max(left.Item2, right.Item2));
        }
    }
}