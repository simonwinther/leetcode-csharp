using System;

namespace leetcode_csharp
{
    public class SameTree
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

        public bool dfs(TreeNode p, TreeNode q){
            if (p is null && q is null)
                return true;
            if (p is null || q is null)
                return false;
            if(p.val != q.val)
                return false;
            
            var left = dfs(p.left, q.left);
            var right = dfs(p.right, q.right);

            return left && right;
        }

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            return dfs(p, q);
        }
    }
}