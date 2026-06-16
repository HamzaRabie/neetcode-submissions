public class Solution {
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> res = new List<List<int>>();

        Queue<TreeNode> q = new Queue<TreeNode>();
        if(root is null) return res;
        q.Enqueue(root);

        while(q.Count > 0)
        {
            int size = q.Count ;
            List<int> lvl = new List<int>();

            //TreeNode node = q.Dequeue();
            for(int i=0 ; i<size ; i++)
            {
                TreeNode node = q.Dequeue();
                lvl.Add(node.val);

                if(node.left is not null)q.Enqueue(node.left);
                if(node.right is not null)q.Enqueue(node.right);
            }
            res.Add(lvl);
        }
        return res;
    }
}