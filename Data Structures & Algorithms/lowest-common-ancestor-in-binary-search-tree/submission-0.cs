public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root is null )return null;

        if(p.val < root.val && q.val < root.val) 
            return LowestCommonAncestor(root.left, p , q);
        
        else if(p.val > root.val && q.val > root.val) 
            return LowestCommonAncestor(root.right, p , q);
        
        return root;
    }

}