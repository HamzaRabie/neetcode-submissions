public class Solution {    
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        return Find(root,subRoot);
    }
    bool Find (TreeNode root, TreeNode subRoot ){
        if(root is null) return false;    

        if(root.val == subRoot.val && Check(root , subRoot)) return true;

        bool L = Find(root.left , subRoot);
        if(L) return true;

        return Find(root.right , subRoot);

    }

    bool Check(TreeNode root, TreeNode subRoot)
    {
        if(root is null && subRoot is null)return true;

        if(root is null || subRoot is null) return false;

        if(root.val != subRoot.val) return false;

        return Check(root.left , subRoot.left) && Check(root.right , subRoot.right) ;
    }
}