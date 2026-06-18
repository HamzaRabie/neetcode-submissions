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
    List<string> str = new List<string>();
    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        
        if(root is null)return "";
        Queue<TreeNode> q= new ();
        StringBuilder res = new StringBuilder();

        q.Enqueue(root);
        while(q.Count > 0)
        {
            int size = q.Count ;
            for(int i=0 ; i<size ; i++)
            {
                TreeNode node = q.Dequeue();
                if(node is null) {res.Append("null");res.Append(",");continue;}
                else{res.Append(node.val);res.Append(",");}
                q.Enqueue(node.left);
                q.Enqueue(node.right);
            }
        }

        return res.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        if (data.Length==0)
            return null;

        string[] tree = data.Split(",");
        
        Queue<TreeNode> q = new Queue<TreeNode>();

        TreeNode root = new TreeNode(int.Parse(tree[0]));

        q.Enqueue(root);

        int i=1;
       
        while(q.Count > 0)
        {
            if(i >= tree.Length-1) break;
            TreeNode node = q.Dequeue();

            if(tree[i] != "null")
            {
                node.left = new TreeNode(int.Parse(tree[i]));
                q.Enqueue(node.left);
            }
            i++;
            if(i >= tree.Length-1) break;
            if(tree[i] != "null")
            {
                node.right = new TreeNode(int.Parse(tree[i]));
                q.Enqueue(node.right);
            }
            i++;
        }
        return root;
     
    }
}
