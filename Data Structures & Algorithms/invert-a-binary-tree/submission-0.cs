public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        return DFS(root);
    }
    TreeNode DFS(TreeNode root)
    {
        if(root is null)return null;

        TreeNode L = DFS(root.left);
        TreeNode R = DFS(root.right);

        root.left = R;
        root.right = L;

        return root;
    }
}