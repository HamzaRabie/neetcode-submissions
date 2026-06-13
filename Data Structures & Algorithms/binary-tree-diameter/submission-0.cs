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

public class Solution {
    int res=0;
    public int DiameterOfBinaryTree(TreeNode root) {
        DFS(root);
        return res;
    }
    int DFS(TreeNode root)
    {
        if(root is null) return 0;

        int L = DFS(root.left);
        int R = DFS(root.right);

        res = Math.Max(res , L+R);

        return 1 + Math.Max(L,R);
    }
}