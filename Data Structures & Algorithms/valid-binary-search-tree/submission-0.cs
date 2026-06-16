public class Solution {
    public bool IsValidBST(TreeNode root) {
        if(root is null)return true;

        return DFS(root , int.MinValue, int.MaxValue);
    }
    bool DFS (TreeNode root , long min = long.MinValue, long max = long.MaxValue)
    {
        if(root is null)return true;

        if(root.val <= min || root.val >= max)return false;

        return DFS(root.left , min , root.val) && DFS(root.right , root.val , max);

    }


}
