public class Solution {
    public List<int> RightSideView(TreeNode root) {
        List<int> res = new List<int>();
        if(root is null)return res;

        Queue<TreeNode> q= new();
        q.Enqueue(root);
        while(q.Count > 0)
        {
            int size = q.Count ;
            int tmp=0;
            for(int i=0 ; i<size ; i++)
            {
                TreeNode node = q.Dequeue();
                if(node.left is not null) q.Enqueue(node.left);
                if(node.right is not null) q.Enqueue(node.right);

                tmp = node.val;
            }
            res.Add(tmp);
        }
        return res;
    }
}
