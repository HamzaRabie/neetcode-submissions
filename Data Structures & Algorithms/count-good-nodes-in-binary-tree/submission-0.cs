public class Solution {
    int res=0;
    public int GoodNodes(TreeNode root) {
        DFS(root , -10000);
        return res;   
    }
    void DFS(TreeNode root , int mx)
    {
        if(root is null)return ;

        if(root.val >= mx) res++;

        mx = Math.Max(mx , root.val);

        DFS(root.left , mx);
        DFS(root.right , mx);

    }
    
}