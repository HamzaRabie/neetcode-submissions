public class Solution {
    public int MaxDepth(TreeNode root) {
        return DFS(root);
    }
    int DFS(TreeNode root)
    {
        if(root is null)return 0;

        return 1 +  Math.Max( DFS(root.left) , DFS(root.right) );
    }
}