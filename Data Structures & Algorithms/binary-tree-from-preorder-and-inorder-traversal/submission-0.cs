public class Solution {
    int i=0;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        Dictionary<int,int> d = new ();
        for(int i=0 ; i<inorder.Length ; i++)
        {
            if(!d.ContainsKey(inorder[i])) d.Add(inorder[i] , i);
        }

        return DFS(0 , preorder.Length-1 , d , preorder );
        
    }
    TreeNode DFS(int l , int r , Dictionary<int,int> d , int[]preorder)
    {
        if(l > r ) return null;

        int val = preorder[i++];
        TreeNode root = new TreeNode(val); // 3

        root.left = DFS(l , d[val]-1 ,  d , preorder);
        root.right = DFS(d[val]+1 , r , d , preorder);

        return root;
    }
}