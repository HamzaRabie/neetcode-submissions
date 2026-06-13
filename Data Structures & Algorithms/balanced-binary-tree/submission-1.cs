public class Solution {
    public bool IsBalanced(TreeNode root)
    {
        return !(DFS(root) == -1 );
    }
    int DFS(TreeNode root)
    {
        if(root is null)return 0;

        int L = DFS(root.left);
        int R = DFS(root.right);

        if(L==-1) return -1;
        if(R==-1) return -1;

        if(Math.Abs(L-R) >1)return -1;

        return 1 + Math.Max(L,R);
    }
}