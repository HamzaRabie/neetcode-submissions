public class Solution {
    bool res=true;
    public bool IsBalanced(TreeNode root)
    {
        DFS(root);
        return res;
    }
    int DFS(TreeNode root)
    {
        if(root is null)return 0;

        int L = DFS(root.left);
        int R = DFS(root.right);

        if(Math.Abs(L-R) >1)res=false;

        return 1 + Math.Max(L,R);

    }
}