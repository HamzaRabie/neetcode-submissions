public class Solution {
    int cnt =0;
    int res=0;
    public int KthSmallest(TreeNode root, int k) {
       DFS(root , k);
       return res;
    }
    void DFS(TreeNode root, int k)
    {
        if(root is null) return ;

        DFS(root.left , k);

        cnt++;
        if(cnt == k){res=root.val ; return;}

        DFS(root.right , k);
    }
}
