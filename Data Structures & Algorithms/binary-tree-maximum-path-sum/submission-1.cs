public class Solution {
    int res = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        DFS(root);
        return res;
    }
    int DFS(TreeNode root)
    {
        if(root is null )return 0;

        int L = Math.Max(DFS(root.left) , 0);
        int R = Math.Max(DFS(root.right) , 0);
        
        res = Math.Max(res , root.val + L + R);

        return Math.Max(L,R) + root.val;
        
    }
}