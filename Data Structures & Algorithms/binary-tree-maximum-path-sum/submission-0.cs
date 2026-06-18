public class Solution {
    int res = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        DFS(root);
        return res;
    }
    int DFS(TreeNode root)
    {
        if(root is null )return int.MinValue;

        int left = DFS(root.left);
        int right = DFS(root.right);

        long l = left;
        long r = right;
        long v = root.val;

        res = (int)Math.Max(res,
            Math.Max(
            Math.Max(l, r),Math.Max(l + r + v,
            Math.Max(Math.Max(l + v, r + v),v)
        )));
        

        return (int)Math.Max(v,Math.Max(l, r) + v);
    }
}
