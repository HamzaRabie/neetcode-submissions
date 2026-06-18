/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Codec {

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
          StringBuilder sb = new StringBuilder();
        DFS(root , sb);
        return sb.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
         string[] tree = data.Split(",");
        int i = 0;
        return buildTree(ref i,tree);
    }

     void DFS(TreeNode root , StringBuilder sb)
    {
        if(root is null){sb.Append("null,");return;}

        sb.Append(root.val);
        sb.Append(",");
        DFS(root.left, sb);
        DFS(root.right, sb);
    }

    TreeNode buildTree(ref int i ,string[] data){
        if(i == data.Length || data[i] == "null")
        {
            i++;
            return null;
        }

        TreeNode root = new TreeNode(int.Parse(data[i]));
        i++; 

        root.left = buildTree(ref i , data);
        root.right = buildTree(ref i , data);

        return root;
    }
}
